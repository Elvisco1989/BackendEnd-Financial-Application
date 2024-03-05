using COPVETFinances.Data;
using COPVETFinances.Interfaces;
using COPVETFinances.Model;

namespace COPVETFinances.Services
{

    
    public class PlayerService : IPlayer
    {

        private AppDBContext Context;

        public PlayerService(AppDBContext context)
        {
            Context = context;
        }

        public void AddBetaling(Player player)
        {
            Context.Players.Add(player);
            Context.SaveChanges();
        }

        public Player GetAllBetaling(int id)
        {
            Player player = Context.Players.FirstOrDefault(p => p.Id == id);
            return player; ;
        }

        public IEnumerable<Player> GetBetaling()
        {
            return Context.Players;
        }

        public void RemoveBetaling(Player player)
        {
            Context.Players.Remove(player);
            Context.SaveChanges();
        }

        public void UpdateBetaling(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
