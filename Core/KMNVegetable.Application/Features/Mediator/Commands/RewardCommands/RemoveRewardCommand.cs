using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.RewardCommands
{
    public class RemoveRewardCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveRewardCommand(int id)
        {
            Id = id;
        }
    }
}
