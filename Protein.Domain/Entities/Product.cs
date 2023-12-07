namespace Protein.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public int Calories {  get; set; }  
        public string? ImageUrl { get; set; }
    }
}
