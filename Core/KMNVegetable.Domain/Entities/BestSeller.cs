namespace KMNVegetable.Domain.Entities
{
    public class BestSeller
    {
        public int BestSellerID { get; set; }

        public string BestSellerProductName { get; set; }

        public string Rating { get; set; }

        public decimal Price { get; set; }

        public Product Product { get; set; }

        public int ProductID { get; set; }
    }
}
