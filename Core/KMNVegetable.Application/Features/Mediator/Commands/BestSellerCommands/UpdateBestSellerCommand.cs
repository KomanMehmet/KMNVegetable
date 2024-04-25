using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands
{
    public class UpdateBestSellerCommand : IRequest
    {
        public int BestSellerID { get; set; }

        public string BestSellerProductName { get; set; }

        public string Rating { get; set; }

        public decimal Price { get; set; }

        public int ProductID { get; set; }
    }
}
