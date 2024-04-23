using COPVETFinances.Interfaces;
using COPVETFinances.Migrations;
using COPVETFinances.Model;
using COPVETFinances.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Financial_Statement
{
    public class FinancialStatementModel : PageModel
    {
        private IIncome income;
        private IExpenditureService1 expenditure;
        private IFamilyDaySevices familyDaySevices;



        public FinancialStatementModel(IIncome income, IExpenditureService1 expenditure, IFamilyDaySevices familyDaySevices)
        {
            this.income = income;
            this.expenditure = expenditure;
            this.familyDaySevices = familyDaySevices;
        }
        [BindProperty]
        public IEnumerable<Expenditure> Expenditure { get; set; }
        [BindProperty]
        public IEnumerable<Income> Incomes { get; set; }

        [BindProperty]
        public IEnumerable<ExpenditureFamilyDay> fam { get; set; }
        [BindProperty]

        public decimal totalIncome { get; set; }
        [BindProperty]

        public decimal totalExpenditure { get; set; }
        [BindProperty]

        public decimal totalFamilyExpenditure { get; set; }
        [BindProperty]

        public decimal Balance { get; set; }
        [BindProperty]

        public decimal Registration { get; set; }
        public void OnGet()
        {
            Incomes = income.GetBetaling();
            totalIncome = income.TotalIncome();
            fam = familyDaySevices.GetBetaling();

           Expenditure = expenditure.GetBetaling();
            totalExpenditure=income.TotalExpenditure();
            Balance = income.Balance();
            Registration = income.Registration();
            totalFamilyExpenditure=familyDaySevices.TotalExpenditureFamily();
        }
    }
}
