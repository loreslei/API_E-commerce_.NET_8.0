namespace RO.DevTest.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}