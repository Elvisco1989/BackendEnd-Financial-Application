using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Food
{
    public class DeleteModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DeleteModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FoodExpenses FoodExpenses { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodexpenses = await _context.FoodExpenses.FirstOrDefaultAsync(m => m.Id == id);

            if (foodexpenses == null)
            {
                return NotFound();
            }
            else
            {
                FoodExpenses = foodexpenses;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodexpenses = await _context.FoodExpenses.FindAsync(id);
            if (foodexpenses != null)
            {
                FoodExpenses = foodexpenses;
                _context.FoodExpenses.Remove(FoodExpenses);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
