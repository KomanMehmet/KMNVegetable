using KMNVegetable.Domain.Entities;

namespace KMNVegetable.Application.Features.Mediator.Results.ProductResults
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }

        public string ProductImageUrl { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal TotalProductPrice { get; set; }

        public int CategoryID { get; set; }
    }
}
