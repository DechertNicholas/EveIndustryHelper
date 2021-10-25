using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class MapConstellationJump
    {
        public int? FromRegionId { get; set; }
        public int FromConstellationId { get; set; }
        public int ToConstellationId { get; set; }
        public int? ToRegionId { get; set; }
    }
}
