namespace KMNVegetable.Dto.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductImageUrl { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal TotalProductPrice { get; set; }

        public int CategoryID { get; set; }
    }
}
