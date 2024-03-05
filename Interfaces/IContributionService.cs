using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IContributionService
    {
        void Add(Expenditure Expenditures);
        Expenditure Get(int id);
        IEnumerable<Expenditure> GetBetaling();
        void Remove(Expenditure Expenditure);
        void Update(Expenditure Expenditure);
    }
}