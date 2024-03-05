using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Members
{
    public class AddNewMemberModel : PageModel
    {
        private IPlayer player;

       

        public AddNewMemberModel(IPlayer player)
        {
            this.player = player;
        }

        [BindProperty]
        public Player Player { get; set; }







        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            player.AddBetaling(Player);
            return RedirectToPage("/Members/ShowALLMember");
        }


    }
}
