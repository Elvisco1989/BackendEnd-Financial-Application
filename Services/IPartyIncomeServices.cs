using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IPartyIncomeServices
    {
        void AddBetaling(PartyIncome income);
        PartyIncome? GetAllBetaling(int id);
        IEnumerable<PartyIncome> GetBetaling();
        void RemoveBetaling(PartyIncome income);
        decimal TotalIncome();
        void UpdateBetaling(Income income);
    }
}