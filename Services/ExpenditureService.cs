using COPVETFinances.Data;
using COPVETFinances.Interfaces;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class ExpenditureService : IExpenditureService1
    {
        private AppDBContext Context;

        public ExpenditureService(AppDBContext context)
        {
            Context = context;
        }

        //public ExpenditureService(AppDBContext dbContext)
        //{
        //    Context = dbContext;
        //}

        public void AddExpenses(Expenditure Expenditures)
        {

            Context.Expenditures.Add(Expenditures);

            Context.SaveChanges();
        }

        public Expenditure GetAllBetaling(int id)
        {
            Expenditure? expenditure = Context.Expenditures.FirstOrDefault(e => e.Id == id);
            return expenditure;
        }

        public IEnumerable<Expenditure> GetBetaling()
        {
            return Context.Expenditures;
        }

        public void RemoveExpenses(Expenditure Expenditure)
        {
            Context.Expenditures.Remove(Expenditure);
            Context.SaveChanges();
        }
        public decimal TotalExpenditure()
        {
            var Cost = Context.Expenditures.Sum(s => s.Amount) + Context.ExpenditureFamilyDays.Sum(s => s.Amount);


            return (decimal)Cost;
        }

        public void UpdateBetaling(Expenditure Expenditure)
        {
            throw new NotImplementedException();
        }
    }
}
