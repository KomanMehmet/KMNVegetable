using KMNVegetable.Application.Features.Mediator.Commands.ProductDetailCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductDetailHandlers
{
    public class CreateProductDetailCommandHandler : IRequestHandler<CreateProductDetailCommand>
    {
        private readonly IRepository<ProductDetail> _repository;

        public CreateProductDetailCommandHandler(IRepository<ProductDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductDetail
            {
                ProductCheck = request.ProductCheck,
                ProductDescription = request.ProductDescription,
                ProductDetailName = request.ProductDetailName,
                ProductMinWeight = request.ProductMinWeight,
                ProductOrigin = request.ProductOrigin,
                ProductPrice = request.ProductPrice,
                ProductQuality = request.ProductQuality,
                ProductRating = request.ProductRating,
                ProductWeight = request.ProductWeight,
                ProductID = request.ProductID
            });
        }
    }
}
