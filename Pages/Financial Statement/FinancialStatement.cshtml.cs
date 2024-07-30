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
        private IParty1 party1;



        public FinancialStatementModel(IIncome income, IExpenditureService1 expenditure, IFamilyDaySevices familyDaySevices, IParty1 party1)
        {
            this.income = income;
            this.expenditure = expenditure;
            this.familyDaySevices = familyDaySevices;
            this.party1 = party1;
        }
        [BindProperty]
        public IEnumerable<Expenditure> Expenditure { get; set; }
        [BindProperty]
        public IEnumerable<Income> Incomes { get; set; }

        [BindProperty]
        public IEnumerable<ExpenditureFamilyDay> fam { get; set; }
        [BindProperty]
        public IEnumerable<Party> party { get; set; }
        [BindProperty]

        public decimal totalIncome { get; set; }
        [BindProperty]

        public decimal totalExpenditure { get; set; }
        [BindProperty]

        public decimal totalFamilyExpenditure { get; set; }
        [BindProperty]

        public decimal PartyExpenses { get; set; }
        [BindProperty]

        public decimal Balance { get; set; }
        [BindProperty]

        public decimal Registration { get; set; }
        public void OnGet()
        {
            Incomes = income.GetBetaling();
            totalIncome = income.TotalIncome();
            fam = familyDaySevices.GetBetaling();
            party = party1.GetBetaling();

            Expenditure = expenditure.GetBetaling();
            totalExpenditure=income.TotalExpenditure();
            Balance = income.Balance();
            Registration = income.Registration();
            totalFamilyExpenditure=familyDaySevices.TotalExpenditureFamily();
            PartyExpenses = party1.TotalPartyExpenses();
        }
    }
}
