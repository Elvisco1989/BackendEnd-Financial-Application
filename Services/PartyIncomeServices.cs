using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class PartyIncomeServices : IPartyIncomeServices
    {
        private AppDBContext Context;

        public PartyIncomeServices(AppDBContext context)
        {
            Context = context;
        }

        public void AddBetaling(PartIncome income)
        {
            Context.PartyIncomes.Add(income);
            Context.SaveChanges();
        }

        //public decimal Balance()
        //{
        //    var Revenue = Context.Income.Sum(s => s.Amount);
        //    var registration = Context.Players.Sum(p => p.Registration);
        //    var Cost = Context.Expenditures.Sum(s => s.Amount) + Context.ExpenditureFamilyDays.Sum(s => s.Amount) + Context.Party1.Sum(s => s.Amount);
        //    //var fam = Context.ExpenditureFamilyDays.Sum(s => s.Amount);
        //    var Profit = (Revenue + registration) - Cost;
        //    return (decimal)Profit; ;
        //}

        public PartIncome? GetAllBetaling(int id)
        {
            PartIncome? income = Context.PartyIncomes.FirstOrDefault(i => i.Id == id);
            return income;
        }

        public IEnumerable<PartIncome> GetBetaling()
        {
            return Context.PartyIncomes;
        }

        //public decimal Registration()
        //{
        //    var registration = Context.Players.Sum(p => p.Registration);

        //    return (decimal)registration;
        //}

        public void RemoveBetaling(PartIncome income)
        {
            Context.PartyIncomes.Remove(income);
            Context.SaveChanges();
        }

        //public decimal TotalExpenditure()
        //{
        //    var Cost = Context.Expenditures.Sum(s => s.Amount) + Context.ExpenditureFamilyDays.Sum(s => s.Amount) + Context.Party1.Sum(s => s.Amount);


        //    return (decimal)Cost;
        //}

        public decimal TotalIncome()
        {

            var Revenue = Context.PartyIncomes.Sum(s => s.Amount);
            if (Revenue == null)
            {
                return 0;
            }

            return (decimal)Revenue;
        }




        public void UpdateBetaling(Income income)
        {
            throw new NotImplementedException();
        }
    }
}

