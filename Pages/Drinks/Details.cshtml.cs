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
    public class DetailsModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DetailsModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        public DrinksExpenses DrinksExpenses { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinksexpenses = await _context.DrinksExpenses.FirstOrDefaultAsync(m => m.Id == id);
            if (drinksexpenses == null)
            {
                return NotFound();
            }
            else
            {
                DrinksExpenses = drinksexpenses;
            }
            return Page();
        }
    }
}
