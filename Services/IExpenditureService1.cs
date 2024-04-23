using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public interface IExpenditureService1
    {
        void AddExpenses(Expenditure Expenditures);
        Expenditure GetAllBetaling(int id);
        IEnumerable<Expenditure> GetBetaling();
        void RemoveExpenses(Expenditure Expenditure);
        decimal TotalExpenditure();
        void UpdateBetaling(Expenditure Expenditure);
    }
}