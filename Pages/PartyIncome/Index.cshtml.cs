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
    public class IndexModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public IndexModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public decimal TotalPartyIncome { get; set; }

        public IList<PartIncome> PartyIncome { get;set; } = default!;

        public async Task OnGetAsync()
        {
            PartyIncome = await _context.PartyIncomes.ToListAsync();
            TotalPartyIncome = (decimal)_context.PartyIncomes.Sum(p => p.Amount);
        }
    }
}
