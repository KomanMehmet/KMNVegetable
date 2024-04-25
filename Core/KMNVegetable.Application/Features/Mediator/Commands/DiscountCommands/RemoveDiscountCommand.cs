using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands
{
    public class RemoveDiscountCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveDiscountCommand(int id)
        {
            Id = id;
        }
    }
}
