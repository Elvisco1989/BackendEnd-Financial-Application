using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Pages.Hall
{
    public class EditModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public EditModel(COPVETFinances.Data.AppDBContext context)
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

            var hallandlogistics =  await _context.HallAndLogistics.FirstOrDefaultAsync(m => m.Id == id);
            if (hallandlogistics == null)
            {
                return NotFound();
            }
            HallAndLogistics = hallandlogistics;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HallAndLogistics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HallAndLogisticsExists(HallAndLogistics.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HallAndLogisticsExists(int id)
        {
            return _context.HallAndLogistics.Any(e => e.Id == id);
        }
    }
}
