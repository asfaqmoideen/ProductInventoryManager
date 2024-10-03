namespace ProductInventoryManager.Models
{
    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal Price { get; set; } = decimal.Zero;

        public int Quantity { get; set; } = 0;

        public string? Description { get; set; }


    }
}
