using COPVETFinances.Model;

namespace COPVETFinances.Interfaces
{
    public interface IpartyIncome
    {
        IEnumerable<Income> GetBetaling();

        public Income GetAllBetaling(int id);

        public void AddBetaling(Income income);

        public void RemoveBetaling(Income income);

        public void UpdateBetaling(Income income);

        public decimal Balance();

        public decimal TotalIncome();

        public decimal TotalExpenditure();

        public decimal Registration();
    }
}
