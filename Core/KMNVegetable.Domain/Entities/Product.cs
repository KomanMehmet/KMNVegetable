namespace KMNVegetable.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductImageUrl { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal TotalProductPrice { get; set; }

        public Category Category { get; set; }

        public int CategoryID { get; set; }

        public List<Discount> Discounts { get; set; }

        public List<ProductDetail> ProductDetails { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
