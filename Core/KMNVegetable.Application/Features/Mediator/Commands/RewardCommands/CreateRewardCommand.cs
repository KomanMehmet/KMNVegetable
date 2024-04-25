using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.RewardCommands
{
    public class CreateRewardCommand : IRequest
    {
        public string RewardTitle { get; set; }

        public string RewardRate { get; set; }
    }
}
