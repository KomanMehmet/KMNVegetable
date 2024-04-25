using KMNVegetable.Application.Features.Mediator.Commands.PromotionCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.PromotionHandlers
{
    public class RemovePromotionCommandHandler : IRequestHandler<RemovePromotionCommand>
    {
        private readonly IRepository<Promotion> _repository;

        public RemovePromotionCommandHandler(IRepository<Promotion> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePromotionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
