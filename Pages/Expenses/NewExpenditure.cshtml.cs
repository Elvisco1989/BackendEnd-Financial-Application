using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Expenses
{
    public class NewExpenditureModel : PageModel
    {
        private IExpenditure expenditure;

        [BindProperty]
        public Expenditure Expenditures { get; set; }

        public NewExpenditureModel(IExpenditure expenditure)
        {
            this.expenditure = expenditure;
        }

       

       

        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {
            expenditure.AddExpenses(Expenditures);
            return RedirectToPage("/Expenses/ShowALLExpenditure");
        }

    }
}
