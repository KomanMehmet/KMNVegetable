using KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.DiscountHandlers
{
    public class RemoveDiscountCommandHandler : IRequestHandler<RemoveDiscountCommand>
    {
        private readonly IRepository<Discount> _repository;

        public RemoveDiscountCommandHandler(IRepository<Discount> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveDiscountCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
