using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Sport
{
    public class IndexModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public IndexModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public decimal TotalSport { get; set; }

        public IList<SportExpenses> SportExpenses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            SportExpenses = await _context.SportExpenses.ToListAsync();
            TotalSport = (decimal)_context.SportExpenses.Sum(s => s.Amount);
        }
    }
}
