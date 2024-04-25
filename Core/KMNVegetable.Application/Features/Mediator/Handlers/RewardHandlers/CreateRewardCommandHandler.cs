using KMNVegetable.Application.Features.Mediator.Commands.RewardCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.RewardHandlers
{
    public class CreateRewardCommandHandler : IRequestHandler<CreateRewardCommand>
    {
        private readonly IRepository<Reward> _repository;

        public CreateRewardCommandHandler(IRepository<Reward> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateRewardCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Reward
            {
                RewardRate = request.RewardRate,
                RewardTitle = request.RewardTitle
            });
        }
    }
}
