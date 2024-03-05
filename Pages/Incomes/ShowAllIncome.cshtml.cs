using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Incomes
{
    public class ShowAllIncomeModel : PageModel
    {
        private IIncome Income;

        [BindProperty]

        public IEnumerable<Income> Incomes{ get; set; }

       

        public ShowAllIncomeModel(IIncome income)
        {
            Income = income;
        }

        public void OnGet()
        {
            Incomes = Income.GetBetaling();
        }
    }
}
