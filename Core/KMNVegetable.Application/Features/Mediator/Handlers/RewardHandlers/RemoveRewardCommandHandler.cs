using KMNVegetable.Application.Features.Mediator.Commands.RewardCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.RewardHandlers
{
    public class RemoveRewardCommandHandler : IRequestHandler<RemoveRewardCommand>
    {
        private readonly IRepository<Reward> _repository;

        public RemoveRewardCommandHandler(IRepository<Reward> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveRewardCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
