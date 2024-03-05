using COPVETFinances.Model;

namespace COPVETFinances.Interfaces
{
    public interface IExpenditure
    {
        IEnumerable<Expenditure> GetBetaling();

        public Expenditure GetAllBetaling(int id);

        public void AddExpenses(Expenditure Expenditures);

        public void RemoveExpenses(Expenditure Expenditure);

        public void UpdateBetaling(Expenditure Expenditure);

    }
}
