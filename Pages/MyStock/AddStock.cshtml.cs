using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.MyStock
{
    public class AddStockModel : PageModel
    {

        private IStock stock;

        public AddStockModel(IStock stock)
        {
            this.stock = stock;
        }
        [BindProperty]
        public Stock stock1 { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {

            stock.Add(stock1);

            return RedirectToPage("/MyStock/ShowStock");
        }
    }
}
