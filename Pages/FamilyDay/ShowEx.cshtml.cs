using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using COPVETFinances.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.FamilyDay
{
    public class ShowExModel : PageModel
    {
        private IFamilyDaySevices fam;
        public ShowExModel(IFamilyDaySevices fam)
        {
            this.fam = fam;
        }

        [BindProperty]

        public IEnumerable<ExpenditureFamilyDay> families { get; set; }

       

        

        public void OnGet()
        {
            families = fam.GetBetaling();
        }
    }
}
