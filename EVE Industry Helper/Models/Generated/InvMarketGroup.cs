using System;
using System.Collections.Generic;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class InvMarketGroup
    {
        public int MarketGroupId { get; set; }
        public int? ParentGroupId { get; set; }
        public string MarketGroupName { get; set; }
        public string Description { get; set; }
        public int? IconId { get; set; }
        public bool? HasTypes { get; set; }
    }
}
