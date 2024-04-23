using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using COPVETFinances.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Expenses
{
    public class ShowAllExpenditureModel : PageModel
    {

        private IExpenditureService1 expenditure;

        [BindProperty]

        public IEnumerable<Expenditure> expenditures { get; set; }

        public ShowAllExpenditureModel(IExpenditureService1 expenditure)
        {
            this.expenditure = expenditure;
        }

        public void OnGet()
        {
            expenditures = expenditure.GetBetaling();
        }
    }
}
