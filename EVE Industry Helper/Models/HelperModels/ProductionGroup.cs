using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVE_Industry_Helper.Models.HelperModels
{
    public class ProductionGroup
    {
        public int? GroupID { get; set; }
        public string GroupName { get; set; }
        public List<Blueprint> ProductionBlueprints { get; set; }
        public List<BlueprintMaterial> ProductionMaterials { get; set; }
    }
}
