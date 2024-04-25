using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands
{
    public class RemoveBestSellerCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveBestSellerCommand(int id)
        {
            Id = id;
        }
    }
}
