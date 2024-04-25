using KMNVegetable.Application.Features.Mediator.Commands.BillingCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BillingHandlers
{
    public class RemoveBillingCommandHandler : IRequestHandler<RemoveBillingCommand>
    {
        private readonly IRepository<Billing> _repository;

        public RemoveBillingCommandHandler(IRepository<Billing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBillingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
