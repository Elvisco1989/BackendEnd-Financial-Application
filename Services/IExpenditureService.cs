using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IExpenditureService
    {
        void AddExpenses(Expenditure Expenditures);
        Expenditure GetAllBetaling(int id);
        IEnumerable<Expenditure> GetBetaling();
        void RemoveExpenses(Expenditure Expenditure);
        decimal TotalExpenditureFamily();
        void UpdateBetaling(Expenditure Expenditure);
    }
}