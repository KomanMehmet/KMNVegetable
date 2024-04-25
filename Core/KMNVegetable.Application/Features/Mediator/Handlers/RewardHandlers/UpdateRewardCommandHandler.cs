
using KMNVegetable.Application.Features.Mediator.Commands.RewardCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.RewardHandlers
{
    public class UpdateRewardCommandHandler : IRequestHandler<UpdateRewardCommand>
    {
        private readonly IRepository<Reward> _repository;

        public UpdateRewardCommandHandler(IRepository<Reward> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateRewardCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.RewardID);

            value.RewardTitle = request.RewardTitle;
            value.RewardRate = request.RewardRate;

            await _repository.UpdateAsync(value);
        }
    }
}
