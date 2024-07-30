using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Party1
{
    public class DeleteModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DeleteModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Party Party { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var party = await _context.Party1.FirstOrDefaultAsync(m => m.Id == id);

            if (party == null)
            {
                return NotFound();
            }
            else
            {
                Party = party;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var party = await _context.Party1.FindAsync(id);
            if (party != null)
            {
                Party = party;
                _context.Party1.Remove(Party);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
