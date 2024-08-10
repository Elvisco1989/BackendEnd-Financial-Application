using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IPartyIncomeServices
    {
        void AddBetaling(PartIncome income);
        PartIncome? GetAllBetaling(int id);
        IEnumerable<PartIncome> GetBetaling();
        void RemoveBetaling(PartIncome income);
        decimal TotalIncome();
        void UpdateBetaling(Income income);
    }
}