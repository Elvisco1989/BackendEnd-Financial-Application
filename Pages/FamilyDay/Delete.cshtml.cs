using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using COPVETFinances.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.FamilyDay
{
    public class DeleteModel : PageModel
    {
        private IFamilyDaySevices expenditure;

        [BindProperty]
        public ExpenditureFamilyDay Expenditure { get; set; }


        

        public DeleteModel(IFamilyDaySevices expenditure)
        {
            this.expenditure = expenditure;
        }

        public void OnGet(int sid)
        {
            Expenditure = expenditure.GetAllBetaling(sid);
        }

        public IActionResult OnPost()
        {
            expenditure.RemoveExpenses(Expenditure);

            return RedirectToPage("/FamilyDay/ShowEx");
        }
    }
}
