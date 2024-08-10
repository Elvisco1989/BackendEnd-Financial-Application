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
    public class IndexModel : PageModel
    {
        private readonly COPVETFinances.Data.AppDBContext _context;

        public IndexModel(COPVETFinances.Data.AppDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public decimal TotalFood { get; set; }

        public IList<FoodExpenses> FoodExpenses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            FoodExpenses = await _context.FoodExpenses.ToListAsync();
            TotalFood = (decimal)_context.FoodExpenses.Sum(f => f.Amount);
        }
    }
}
