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
    public class DeleteModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DeleteModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SportExpenses SportExpenses { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportexpenses = await _context.SportExpenses.FirstOrDefaultAsync(m => m.Id == id);

            if (sportexpenses == null)
            {
                return NotFound();
            }
            else
            {
                SportExpenses = sportexpenses;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportexpenses = await _context.SportExpenses.FindAsync(id);
            if (sportexpenses != null)
            {
                SportExpenses = sportexpenses;
                _context.SportExpenses.Remove(SportExpenses);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
