using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class InvControlTowerResource
    {
        public int ControlTowerTypeId { get; set; }
        public int ResourceTypeId { get; set; }
        public int? Purpose { get; set; }
        public int? Quantity { get; set; }
        public double? MinSecurityLevel { get; set; }
        public int? FactionId { get; set; }
    }
}
