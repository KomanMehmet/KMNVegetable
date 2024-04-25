using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.ProductDetailCommands
{
    public class RemoveProductDetailCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductDetailCommand(int id)
        {
            Id = id;
        }
    }
}
