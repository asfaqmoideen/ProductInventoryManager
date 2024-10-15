namespace ProductInventoryManager.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public required string CustomerName { get; set; }

        public List<Product> Products { get; set; } = null!;

        public bool IsPaid { get; set; } = false;

        public decimal Discount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Email { get; set;  } 


    }
}
