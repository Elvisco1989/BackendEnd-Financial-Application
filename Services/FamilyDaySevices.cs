using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class FamilyDaySevices : IFamilyDaySevices
    {
        private AppDBContext Context;

        public FamilyDaySevices(AppDBContext context)
        {
            Context = context;
        }

        public void AddBetaling(ExpenditureFamilyDay income)
        {
            Context.ExpenditureFamilyDays.Add(income);
            Context.SaveChanges();
        }
        public ExpenditureFamilyDay? GetAllBetaling(int id)
        {
            ExpenditureFamilyDay? expenditure = Context.ExpenditureFamilyDays.FirstOrDefault(e => e.Id == id);
            return expenditure;
        }

        public IEnumerable<ExpenditureFamilyDay> GetBetaling()
        {
            return Context.ExpenditureFamilyDays;
        }

        public void RemoveExpenses(ExpenditureFamilyDay Expenditure)
        {
            Context.ExpenditureFamilyDays.Remove(Expenditure);
            Context.SaveChanges();
        }
        public decimal TotalExpenditureFamily()
        {
            var Cost = Context.ExpenditureFamilyDays.Sum(s => s.Amount);


            return (decimal)Cost;
        }

        public void UpdateBetaling(ExpenditureFamilyDay Expenditure)
        {
            throw new NotImplementedException();
        }






    }
}
