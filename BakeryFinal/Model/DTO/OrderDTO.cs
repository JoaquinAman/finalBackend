namespace BakeryFinal.Model.DTO
{
    public class OrderDTO
    {
        public float TotalPrice { get; set; }
        public int BakeryOfficeId { get; set; }
        public virtual ICollection<BreadOrderDTO> BreadOrder { get; set; } = null!;
        public string Status { get; set; }
    }
}
