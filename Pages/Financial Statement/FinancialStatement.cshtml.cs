using COPVETFinances.Interfaces;
using COPVETFinances.Migrations;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Financial_Statement
{
    public class FinancialStatementModel : PageModel
    {
        private IIncome income;
        private IExpenditure expenditure;



        public FinancialStatementModel(IIncome income, IExpenditure expenditure)
        {
            this.income = income;
            this.expenditure = expenditure;
        }
        [BindProperty]
        public IEnumerable<Expenditure> Expenditure { get; set; }
        [BindProperty]
        public IEnumerable<Income> Incomes { get; set; }
        [BindProperty]

        public decimal totalIncome { get; set; }
        [BindProperty]

        public decimal totalExpenditure { get; set; }
        [BindProperty]

        public decimal Balance { get; set; }
        [BindProperty]

        public decimal Registration { get; set; }
        public void OnGet()
        {
            Incomes = income.GetBetaling();
            totalIncome = income.TotalIncome();

           Expenditure = expenditure.GetBetaling();
            totalExpenditure=income.TotalExpenditure();
            Balance = income.Balance();
            Registration = income.Registration();
        }
    }
}
