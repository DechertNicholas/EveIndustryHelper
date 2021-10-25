using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class WarCombatZone
    {
        public int CombatZoneId { get; set; }
        public string CombatZoneName { get; set; }
        public int? FactionId { get; set; }
        public int? CenterSystemId { get; set; }
        public string Description { get; set; }
    }
}
