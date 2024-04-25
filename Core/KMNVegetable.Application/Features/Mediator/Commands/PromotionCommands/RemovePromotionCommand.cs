using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.PromotionCommands
{
    public class RemovePromotionCommand : IRequest
    {
        public int Id { get; set; }

        public RemovePromotionCommand(int id)
        {
            Id = id;
        }
    }
}
