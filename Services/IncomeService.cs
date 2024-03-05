using COPVETFinances.Data;
using COPVETFinances.Interfaces;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class IncomeService : IIncome
    {
        private AppDBContext Context;

        public IncomeService(AppDBContext context)
        {
            Context = context;
        }

        public void AddBetaling(Income income)
        {
            Context.Income.Add(income);
            Context.SaveChanges();
        }

        public decimal Balance()
        {
            var Revenue = Context.Income.Sum(s => s.Amount);
            var registration = Context.Players.Sum(p => p.Registration);
            var Cost = Context.Expenditures.Sum(s => s.Amount);
            var Profit = (Revenue + registration) - Cost;
            return (decimal)Profit; ;
        }

        public Income GetAllBetaling(int id)
        {
            Income income = Context.Income.FirstOrDefault(i => i.Id == id);
            return income;
        }

        public IEnumerable<Income> GetBetaling()
        {
           return Context.Income;
        }

        public decimal Registration()
        {
            var registration = Context.Players.Sum(p => p.Registration);

            return(decimal)registration;
        }

        public void RemoveBetaling(Income income)
        {
            Context.Income.Remove(income);
            Context.SaveChanges();
        }

        public decimal TotalExpenditure()
        {
            var Cost = Context.Expenditures.Sum(s => s.Amount);

            return (decimal)Cost;
        }

        public decimal TotalIncome()
        {

            var Revenue = Context.Income.Sum(s => s.Amount);
            var registration = Context.Players.Sum(p => p.Registration);
            
            var Income = Revenue+ registration;
            return (decimal)Income;
        }



        public void UpdateBetaling(Income income)
        {
            throw new NotImplementedException();
        }
    }
}
