using KMNVegetable.Application.Features.Mediator.Commands.ProductCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                CategoryID = request.CategoryID,
                ProductDescription = request.ProductDescription,
                ProductName = request.ProductName,
                ProductImageUrl = request.ProductImageUrl,
                ProductPrice = request.ProductPrice,
                TotalProductPrice = request.TotalProductPrice
            });
        }
    }
}
