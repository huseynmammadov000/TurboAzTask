namespace TurboAzTask.Models
{
    public class Car :BaseEntity
    {
        public string Name { get; set; }
        public string Vendor { get; set; } 
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
