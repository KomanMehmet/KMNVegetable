using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands
{
    public class CreateBestSellerCommand : IRequest
    {
        public string BestSellerProductName { get; set; }

        public string Rating { get; set; }

        public decimal Price { get; set; }

        public int ProductID { get; set; }
    }
}
