using EVE_Industry_Helper.Models.Generated;
using EVE_Industry_Helper.Models.HelperModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVE_Industry_Helper.Pages
{
    public class IndexModel : PageModel
    {
        public Blueprint SelectedBlueprint { get; set; }
        public List<ProductionGroup> ProductionGroups { get; set; }
        public string ShipName = "Rokh";
        private readonly ILogger<IndexModel> _logger;
        private readonly evesdeContext _db;

        public IndexModel(ILogger<IndexModel> logger, evesdeContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task OnGet()
        {
            // Cache all sql queries, as they are reused often
            var productTypeInfo = await _db.InvTypes
                .Where(i => i.TypeName == ShipName)
                .FirstOrDefaultAsync();

            var productGroupInfo = await _db.InvGroups
                .Where(i => i.GroupId == productTypeInfo.GroupId)
                .FirstOrDefaultAsync();

            var blueprintIndustryInfo = await _db.IndustryActivityProducts
                .Where(i => i.ProductTypeId == productTypeInfo.TypeId)
                .FirstOrDefaultAsync();

            var blueprintInfo = await _db.InvTypes
                .Where(i => i.TypeId == blueprintIndustryInfo.TypeId)
                .FirstOrDefaultAsync();

            var blueprintGroupInfo = await _db.InvGroups
                .Where(i => i.GroupId == blueprintInfo.GroupId)
                .FirstOrDefaultAsync();

            SelectedBlueprint = new Blueprint
            {
                Name = blueprintInfo.TypeName,

                TypeID = blueprintInfo.TypeId,

                GroupID = blueprintInfo.GroupId,

                GroupName = blueprintGroupInfo.GroupName,

                //JobCost = too hard to calculate right now

                ProductName = ShipName,

                ProductTypeID = productTypeInfo.TypeId,

                ProductGroupName = productGroupInfo.GroupName,

                OutputQuantity = blueprintIndustryInfo.Quantity
            };

            foreach (var material in _db.IndustryActivityMaterials
                .Where(i => i.TypeId == SelectedBlueprint.TypeID)
                .Where(i => i.ActivityId == 1))// 1 = Manufacture
            {
                SelectedBlueprint.BillOfMaterials.Add(new BlueprintMaterial
                {
                    Quantity = material.Quantity,
                    TypeID = material.MaterialTypeId,
                    Name = _db.InvTypes
                        .Where(i => i.TypeId == material.MaterialTypeId)
                        .FirstOrDefault()
                        .TypeName,
                    GroupID = _db.InvTypes
                        .Where(i => i.TypeId == material.MaterialTypeId)
                        .FirstOrDefault()
                        .GroupId
                });
            }
        }

        public List<ProductionGroup> BuildProductionGroups(Blueprint blueprint)
        {
            // generate a list of group IDs from the blueprint
            // see if each material is a product of a blueprint
            // if so, add that blueprint to the production group's blueprint list
            // if not, that material is a base material to be obtained by the player
            // so, add that material to the groups material list for purchase/obtain
            var productionGroup = new ProductionGroup();
        }
    }
}
