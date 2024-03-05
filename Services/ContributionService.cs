using COPVETFinances.Data;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class ContributionService : IContributionService
    {
        private AppDBContext Context;

        public ContributionService(AppDBContext context)
        {
            Context = context;
        }



        //public ExpenditureService(AppDBContext dbContext)
        //{
        //    Context = dbContext;
        //}

        public void Add(Expenditure Expenditures)
        {

            Context.Expenditures.Add(Expenditures);

            Context.SaveChanges();
        }

        public Expenditure Get(int id)
        {
            Expenditure expenditure = Context.Expenditures.FirstOrDefault(e => e.Id == id);
            return expenditure;
        }

        public IEnumerable<Expenditure> GetBetaling()
        {
            return Context.Expenditures;
        }

        public void Remove(Expenditure Expenditure)
        {
            Context.Expenditures.Remove(Expenditure);
            Context.SaveChanges();
        }

        public void Update(Expenditure Expenditure)
        {
            throw new NotImplementedException();
        }
    }
}
