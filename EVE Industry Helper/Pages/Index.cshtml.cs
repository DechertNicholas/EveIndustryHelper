using EVE_Industry_Helper.Models.Generated;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVE_Industry_Helper.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly evesdeContext _db;
        public IEnumerable<InvGroup> InvGroups { get; set; }

        public IndexModel(ILogger<IndexModel> logger, evesdeContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task OnGet()
        {
            InvGroups = await _db.InvGroups.ToListAsync();
        }
    }
}
