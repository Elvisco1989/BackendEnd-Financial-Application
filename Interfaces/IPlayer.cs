using COPVETFinances.Model;

namespace COPVETFinances.Interfaces
{
    public interface IPlayer
    {
        IEnumerable<Player> GetBetaling();

        public Player GetAllBetaling(int id);

        public void AddBetaling(Player player);

        public void RemoveBetaling(Player player);

        public void UpdateBetaling(Player player);

    }
}
