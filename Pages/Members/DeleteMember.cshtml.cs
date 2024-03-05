using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Members
{
    public class DeleteMemberModel : PageModel
    {
        private IPlayer Player;

        public DeleteMemberModel(IPlayer player)
        {
            Player = player;
        }

        [BindProperty]
        public Player Players { get; set; }


       

        public void OnGet(int sid)
        {
            Players = Player.GetAllBetaling(sid);
        }

        public IActionResult OnPost()
        {
            Player.RemoveBetaling(Players);

            return RedirectToPage("/Members/ShowALLMember");
        }
    }
}
