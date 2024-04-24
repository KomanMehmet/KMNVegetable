namespace KMNVegetable.Domain.Entities
{
    public class ProductDetail
    {
        public int ProductDetailID { get; set; }

        public string ProductDetailName { get; set; }

        public Product Product { get; set; }

        public int ProductID { get; set; }

        public decimal ProductPrice  { get; set; }

        public int ProductRating  { get; set; }

        public string ProductDescription { get; set; }

        public string ProductWeight { get; set; }

        public string ProductOrigin { get; set; }

        public string ProductQuality { get; set; }

        public string ProductCheck { get; set; }

        public string ProductMinWeight { get; set; }
    }
}
