using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IFamilyDaySevices
    {
        void AddBetaling(ExpenditureFamilyDay income);
        ExpenditureFamilyDay? GetAllBetaling(int id);
        IEnumerable<ExpenditureFamilyDay> GetBetaling();
        void RemoveExpenses(ExpenditureFamilyDay Expenditure);
        decimal TotalExpenditureFamily();
        void UpdateBetaling(ExpenditureFamilyDay Expenditure);
    }
}