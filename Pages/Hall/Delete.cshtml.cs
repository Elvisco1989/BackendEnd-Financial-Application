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
    public class DeleteModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DeleteModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HallAndLogistics HallAndLogistics { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hallandlogistics = await _context.HallAndLogistics.FirstOrDefaultAsync(m => m.Id == id);

            if (hallandlogistics == null)
            {
                return NotFound();
            }
            else
            {
                HallAndLogistics = hallandlogistics;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hallandlogistics = await _context.HallAndLogistics.FindAsync(id);
            if (hallandlogistics != null)
            {
                HallAndLogistics = hallandlogistics;
                _context.HallAndLogistics.Remove(HallAndLogistics);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
