using COPVETFinances.Model;

namespace COPVETFinances.Interfaces
{
    public interface IStock
    {

        IEnumerable<Stock> GetStock();

        public Stock GetALLStock(int id);

        public void Add(Stock stock);

        public void Remove(Stock stock);

        public void Update(Stock stock);
    }
}
