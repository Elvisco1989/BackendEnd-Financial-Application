using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Expenses
{
    public class ShowAllExpenditureModel : PageModel
    {

        private IExpenditure expenditure;

        [BindProperty]

        public IEnumerable<Expenditure> expenditures { get; set; }

        public ShowAllExpenditureModel(IExpenditure expenditure)
        {
            this.expenditure = expenditure;
        }

        public void OnGet()
        {
            expenditures = expenditure.GetBetaling();
        }
    }
}
