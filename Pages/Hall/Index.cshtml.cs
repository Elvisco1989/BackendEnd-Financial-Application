using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Hall
{
    public class IndexModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public IndexModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public decimal TotalHallAndLogistics { get; set; }
        public IList<HallAndLogistics> HallAndLogistics { get;set; } = default!;

        public async Task OnGetAsync()
        {
            HallAndLogistics = await _context.HallAndLogistics.ToListAsync();
            TotalHallAndLogistics = (decimal)_context.HallAndLogistics.Sum(h => h.Amount);
        }
    }
}
