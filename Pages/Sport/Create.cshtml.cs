using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Sport
{
    public class CreateModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public CreateModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SportExpenses SportExpenses { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SportExpenses.Add(SportExpenses);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
