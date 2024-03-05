using COPVETFinances.Data;
using COPVETFinances.Interfaces;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{
    public class StockService : IStock
    {

        private AppDBContext Context;

        public StockService(AppDBContext context)
        {
            Context = context;
        }

        public void Add(Stock stock)
        {
            Context.Stocks.Add(stock);

           Context.SaveChanges();
        }

        public Stock GetALLStock(int id)
        {
           Stock stock = Context.Stocks.FirstOrDefault(S=>S.Id==id);

            return stock;
        }

        public IEnumerable<Stock> GetStock()
        {
            return Context.Stocks;
        }

        public void Remove(Stock stock)
        {
            Context.Stocks.Remove(stock); ;
        }

        public void Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
