using COPVETFinances.Data;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace COPVETFinances.Pages.PartyFinancialStatement
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;

        public IndexModel(AppDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public decimal TotalPartyIncome { get; set; }
        [BindProperty]
        public decimal TotalPartyExpenses { get; set; }
        [BindProperty]
        public decimal TotalDrinks { get; set; }
        [BindProperty]
        public decimal TotalHall { get; set; }
        [BindProperty]
        public decimal TotalFood { get; set; }
        [BindProperty]
        public decimal TotalSport { get; set; }
        [BindProperty]





        public IEnumerable<PartIncome> Incomes { get; set; }
        [BindProperty]
        public IEnumerable<FoodExpenses> Expenses { get; set; }
        [BindProperty]
        public IEnumerable<DrinksExpenses> Drinks { get; set; }
        [BindProperty]

        public IEnumerable<HallAndLogistics> halls { get; set; }
        [BindProperty]

        public IEnumerable<SportExpenses> sports { get; set; }
        [BindProperty]

        public decimal profit { get; set; }
        [BindProperty]

        public decimal TotalExpenditure { get; set; }



        public  void OnGetAsync()
        {
            Incomes = _context.PartyIncomes;
            TotalPartyIncome = (decimal)_context.PartyIncomes.Sum(p => p.Amount);

            Expenses = _context.FoodExpenses;
            TotalFood = (decimal)_context.FoodExpenses.Sum(p => p.Amount);

            Drinks = _context.DrinksExpenses;
            TotalDrinks += (decimal)_context.DrinksExpenses.Sum(p => p.Amount);

            halls = _context.HallAndLogistics;
            TotalHall += (decimal)_context.HallAndLogistics.Sum(p => p.Amount);

            sports = _context.SportExpenses;
            TotalSport += (decimal)_context.SportExpenses.Sum(p => p.Amount);
            TotalExpenditure = TotalDrinks + TotalFood + TotalHall + TotalSport;
            profit = TotalPartyIncome - TotalExpenditure;
        }


       
    }
}
