namespace BakeryFinal.Model.DTO
{
    public class BreadDTO
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string CookingTime { get; set; } = string.Empty;
        public string RestingTime { get; set; } = string.Empty;
        public string FermentTime { get; set; } = string.Empty;
        public string CookingTemperature { get; set; } = string.Empty;
        public ICollection<int> IdIngredient { get; set; } = null!;
        public ICollection<int> IdStep { get; set; } = null!;
        public BakeryOfficeDTO Bakery { get; set; } = null!;
    }
}
