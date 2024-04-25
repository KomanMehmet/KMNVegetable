namespace KMNVegetable.Application.Features.Mediator.Results.BestSellerResults
{
    public class GetBestSellerByIdQueryResult
    {
        public int BestSellerID { get; set; }

        public string BestSellerProductName { get; set; }

        public string Rating { get; set; }

        public decimal Price { get; set; }

        public int ProductID { get; set; }
    }
}
