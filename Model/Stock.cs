using System.ComponentModel.DataAnnotations;

namespace COPVETFinances.Model
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public double AmountInStock { get; set; }

        public string Location { get; set; }

        public DateTime recieve { get; set; }


    }
}
