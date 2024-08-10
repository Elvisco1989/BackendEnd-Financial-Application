using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Drinks
{
    public class IndexModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public IndexModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public decimal TotalDrinks { get; set; }

        public IList<DrinksExpenses> DrinksExpenses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            DrinksExpenses = await _context.DrinksExpenses.ToListAsync();
            TotalDrinks = (decimal)_context.DrinksExpenses.Sum(d => d.Amount);
        }
    }
}
