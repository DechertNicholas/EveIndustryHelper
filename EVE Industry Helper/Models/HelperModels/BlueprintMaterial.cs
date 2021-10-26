using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVE_Industry_Helper.Models.HelperModels
{
    public class BlueprintMaterial
    {
        public string Name { get; set; }
        public int? TypeID { get; set; }
        public int? GroupID { get; set; }
        public int? Quantity { get; set; }
        // Quantity needed after material reduction calculations
        public int EffectiveQuantity { get; set; }
    }
}
