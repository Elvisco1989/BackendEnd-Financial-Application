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
    public class DeleteModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DeleteModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinksexpenses = await _context.DrinksExpenses.FindAsync(id);
            if (drinksexpenses != null)
            {
                DrinksExpenses = drinksexpenses;
                _context.DrinksExpenses.Remove(DrinksExpenses);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
