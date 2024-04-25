using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.RewardCommands
{
    public class UpdateRewardCommand : IRequest
    {
        public int RewardID { get; set; }

        public string RewardTitle { get; set; }

        public string RewardRate { get; set; }
    }
}
