using System.ComponentModel.DataAnnotations;

namespace BakeryFinal.Model.Domain
{
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public int BakeryOfficeId { get; set; }
        public virtual ICollection<BreadOrder> BreadOrder { get; set; } = null!;
        [Required]
        public string Status { get; set; }
    }
}
