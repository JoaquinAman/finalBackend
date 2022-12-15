using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BakeryFinal.Model.Domain
{
    public class BreadOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdBread { get; set; }
        public Bread Bread { get; set; }
        [Required]
        public int IdOrder { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
