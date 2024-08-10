using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.PartyIncome
{
    public class DeleteModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DeleteModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PartIncome PartyIncome { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partyincome = await _context.PartyIncomes.FirstOrDefaultAsync(m => m.Id == id);

            if (partyincome == null)
            {
                return NotFound();
            }
            else
            {
                PartyIncome = partyincome;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partyincome = await _context.PartyIncomes.FindAsync(id);
            if (partyincome != null)
            {
                PartyIncome = partyincome;
                _context.PartyIncomes.Remove(PartyIncome);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
