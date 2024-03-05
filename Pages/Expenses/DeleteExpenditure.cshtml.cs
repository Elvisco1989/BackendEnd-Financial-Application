using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Expenses
{
    public class DeleteExpenditureModel : PageModel
    {

        private IExpenditure expenditure;

        [BindProperty]
        public Expenditure Expenditure { get; set; }


        public DeleteExpenditureModel(IExpenditure expenditure)
        {
            this.expenditure = expenditure;
        }

        public void OnGet(int sid)
        {
            Expenditure = expenditure.GetAllBetaling(sid);
        }

        public      IActionResult OnPost()
        {
            expenditure.RemoveExpenses(Expenditure);

            return RedirectToPage("/Expenses/ShowALLExpenditure");
        }
    }
}
