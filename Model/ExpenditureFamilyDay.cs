using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace COPVETFinances.Model
{
    public class ExpenditureFamilyDay
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]

        public string? Name { get; set; }

        [StringLength(100)]

        public string? Description { get; set; }

        public decimal? Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
