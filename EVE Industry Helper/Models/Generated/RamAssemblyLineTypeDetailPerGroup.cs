using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class RamAssemblyLineTypeDetailPerGroup
    {
        public int AssemblyLineTypeId { get; set; }
        public int GroupId { get; set; }
        public double? TimeMultiplier { get; set; }
        public double? MaterialMultiplier { get; set; }
        public double? CostMultiplier { get; set; }
    }
}
