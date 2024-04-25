using KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.DiscountHandlers
{
    public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand>
    {
        private readonly IRepository<Discount> _repository;

        public UpdateDiscountCommandHandler(IRepository<Discount> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.DiscountID);

            value.DiscoundProductName = request.DiscoundProductName;
            value.DiscoundProductAmount = request.DiscoundProductAmount;
            value.ProductID = request.ProductID;

            await _repository.UpdateAsync(value);   
        }
    }
}
