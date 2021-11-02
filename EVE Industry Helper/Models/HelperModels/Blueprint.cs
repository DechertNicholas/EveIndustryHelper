using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVE_Industry_Helper.Models.HelperModels
{
    public class Blueprint
    {
        public string Name { get; set; }
        public int? TypeID { get; set; }
        public int? GroupID { get; set; }
        public string GroupName { get; set; }
        public float JobCost { get; set; }
        public string ProductName { get; set; }
        public int? ProductTypeID { get; set; }
        public string ProductGroupName { get; set; }
        public int? OutputQuantity { get; set; }
        public int MaterialEfficiency { get; set; }
        public int TimeEfficiency { get; set; }
        public List<BlueprintMaterial> BillOfMaterials { get; set; }

        public Blueprint()
        {
            if (BillOfMaterials == null)
            {
                BillOfMaterials = new List<BlueprintMaterial>();
            }
        }
    }
}
