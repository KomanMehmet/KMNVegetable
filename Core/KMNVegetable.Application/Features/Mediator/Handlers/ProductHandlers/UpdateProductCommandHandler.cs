using KMNVegetable.Application.Features.Mediator.Commands.ProductCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ProductID);

            value.ProductDescription = request.ProductDescription;
            value.TotalProductPrice = request.TotalProductPrice;
            value.ProductPrice = request.ProductPrice;
            value.ProductName = request.ProductName;
            value.CategoryID = request.CategoryID;
            value.ProductName = request.ProductName;

            await _repository.UpdateAsync(value);
        }
    }
}
