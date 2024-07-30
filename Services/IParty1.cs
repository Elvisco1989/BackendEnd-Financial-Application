using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IParty1
    {
        void AddBetaling(Party income);
        Party GetAllBetaling(int id);
        IEnumerable<Party> GetBetaling();
        void RemoveExpenses(Party Expenditure);
        decimal TotalPartyExpenses();
        void UpdateBetaling(Party Expenditure);
    }
}
