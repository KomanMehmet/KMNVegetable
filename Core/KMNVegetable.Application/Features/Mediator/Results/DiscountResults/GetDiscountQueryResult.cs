using KMNVegetable.Domain.Entities;

namespace KMNVegetable.Application.Features.Mediator.Results.DiscountResults
{
    public class GetDiscountQueryResult
    {
        public int DiscountID { get; set; }

        public string DiscoundProductName { get; set; }

        public string DiscoundProductAmount { get; set; }

        public int ProductID { get; set; }
    }
}
