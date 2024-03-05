using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.MyStock
{
    public class ShowStockModel : PageModel
    {

        private IStock stock;

        public ShowStockModel(IStock stock)
        {
            this.stock = stock;
        }

        public IEnumerable<Stock> Stocks { get; set; }

        public void OnGet()
        {
            Stocks = stock.GetStock();
        }
    }
}
