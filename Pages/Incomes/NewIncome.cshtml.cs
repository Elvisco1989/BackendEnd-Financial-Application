using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace COPVETFinances.Pages.Incomes
{
    public class NewIncomeModel : PageModel
    {
        private IIncome Income;

        public NewIncomeModel(IIncome income)
        {
            Income = income;
        }

        [BindProperty]
        public Income Incomes { get; set; }

        





        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {
            Income.AddBetaling(Incomes);
            return RedirectToPage("/Incomes/ShowALLIncome");
        }

        
        
       
    }
}
