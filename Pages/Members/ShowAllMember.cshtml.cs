using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COPVETFinances.Pages.Members
{
    public class ShowAllMemberModel : PageModel
    {
        private IPlayer player;

        public ShowAllMemberModel(IPlayer player)
        {
            this.player = player;
        }

        [BindProperty]

        public IEnumerable<Player> players { get; set; }



        


        public void OnGet()
        {
            players = player.GetBetaling();
        }
    }
}
