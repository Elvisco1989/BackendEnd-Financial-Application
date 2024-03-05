using COPVETFinances.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Account
{
    public class BalanceModel : PageModel
    {
        private IIncome income;

        public BalanceModel(IIncome income)
        {
            this.income = income;
        }

        [BindProperty]

        public decimal Balance { get; set; }





        public void OnGet()
        {
            Balance = income.Balance();
        }
    }
}
