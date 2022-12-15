using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BakeryFinal.Model.Domain
{
    public class Bread
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public float Price { get; set; }

        public virtual ICollection<BreadOrder> BreadOrder { get; set; } = null!;

    }
}
