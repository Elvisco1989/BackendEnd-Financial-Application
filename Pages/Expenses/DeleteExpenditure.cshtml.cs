using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using COPVETFinances.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Expenses
{
    public class DeleteExpenditureModel : PageModel
    {

        private IExpenditureService1 expenditure;

        [BindProperty]
        public Expenditure Expenditure { get; set; }


        public DeleteExpenditureModel(IExpenditureService1 expenditure)
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
