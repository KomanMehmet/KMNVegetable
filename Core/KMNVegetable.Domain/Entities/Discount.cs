namespace KMNVegetable.Domain.Entities
{
    public class Discount
    {
        public int DiscountID { get; set; }

        public string DiscoundProductName { get; set; }

        public string DiscoundProductAmount { get; set; }

        public Product Product { get; set; }

        public int ProductID { get; set; }
    }
}
