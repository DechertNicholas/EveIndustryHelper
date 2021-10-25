using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class InvGroup
    {
        public int GroupId { get; set; }
        public int? CategoryId { get; set; }
        public string GroupName { get; set; }
        public int? IconId { get; set; }
        public bool? UseBasePrice { get; set; }
        public bool? Anchored { get; set; }
        public bool? Anchorable { get; set; }
        public bool? FittableNonSingleton { get; set; }
        public bool? Published { get; set; }
    }
}
