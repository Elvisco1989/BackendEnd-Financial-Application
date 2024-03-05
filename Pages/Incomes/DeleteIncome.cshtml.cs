using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Incomes
{
    public class DeleteIncomeModel : PageModel
    {
        private IIncome income;

        [BindProperty]
        public Income incomes { get; set; }


       

        public DeleteIncomeModel(IIncome income)
        {
            this.income = income;
        }

        public void OnGet(int sid)
        {
            incomes = income.GetAllBetaling(sid);
        }

        public IActionResult OnPost()
        {
            income.RemoveBetaling(incomes);

            return RedirectToPage("/Incomes/ShowALLIncome");
        }
    }
}
