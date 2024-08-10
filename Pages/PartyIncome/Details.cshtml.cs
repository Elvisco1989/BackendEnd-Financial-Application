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
    public class DetailsModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public DetailsModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }

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
    }
}
