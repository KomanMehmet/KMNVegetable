using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.ProductCommands
{
    public class RemoveProductCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
