using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class MapSolarSystemJump
    {
        public int? FromRegionId { get; set; }
        public int? FromConstellationId { get; set; }
        public int FromSolarSystemId { get; set; }
        public int ToSolarSystemId { get; set; }
        public int? ToConstellationId { get; set; }
        public int? ToRegionId { get; set; }
    }
}
