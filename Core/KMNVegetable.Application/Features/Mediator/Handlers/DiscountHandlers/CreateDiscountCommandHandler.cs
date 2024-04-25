using KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.DiscountHandlers
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand>
    {
        private readonly IRepository<Discount> _repository;

        public CreateDiscountCommandHandler(IRepository<Discount> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Discount
            {
                DiscoundProductAmount = request.DiscoundProductAmount,
                DiscoundProductName = request.DiscoundProductName,
                ProductID = request.ProductID,
            });
        }
    }
}
