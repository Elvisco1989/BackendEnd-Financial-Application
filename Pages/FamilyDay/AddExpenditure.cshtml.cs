using COPVETFinances.Model;
using COPVETFinances.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.FamilyDay
{
    public class AddExpenditureModel : PageModel
    {
        private IFamilyDaySevices fam;

        public AddExpenditureModel(IFamilyDaySevices fam)
        {
            this.fam = fam;
        }
        [BindProperty]
        public ExpenditureFamilyDay familyDay { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            fam.AddBetaling(familyDay);
            return RedirectToPage("/FamilyDay/ShowEx");
        }
    }
}
