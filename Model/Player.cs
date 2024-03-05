using System.ComponentModel.DataAnnotations;

namespace COPVETFinances.Model
{
    public class Player
    {
       [ Key]
        public int  Id { get; set; }

        public string Name { get; set; }

        public string Position{ get; set; }

        public string Method { get; set; }


        public decimal Registration { get; set; }
    }
}
