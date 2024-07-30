using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class Party1Services : IParty1
    {
        private AppDBContext Context;

        public Party1Services(AppDBContext context)
        {
            Context = context;
        }

        public void AddBetaling(Party income)
        {
            Context.Party1.Add(income);
            Context.SaveChanges();
        }

        public Party GetAllBetaling(int id)
        {
            Party? party = Context.Party1.FirstOrDefault(p=>p.Id==id);
            return party;
        }

        public IEnumerable<Party> GetBetaling()
        {
            return Context.Party1;
        }

        public void RemoveExpenses(Party Expenditure)
        {
            Context.Party1.Remove(Expenditure);
            Context.SaveChanges();
        }

        public decimal TotalPartyExpenses()
        {
            var Cost =  Context.Party1.Sum(S=>S.Amount);


            return (decimal)Cost;
        }

        public void UpdateBetaling(Party Expenditure)
        {
            throw new NotImplementedException();
        }
    }
}
