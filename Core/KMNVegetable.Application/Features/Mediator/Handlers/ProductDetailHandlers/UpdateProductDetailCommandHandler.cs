using KMNVegetable.Application.Features.Mediator.Commands.ProductDetailCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductDetailHandlers
{
    public class UpdateProductDetailCommandHandler : IRequestHandler<UpdateProductDetailCommand>
    {
        private readonly IRepository<ProductDetail> _repository;

        public UpdateProductDetailCommandHandler(IRepository<ProductDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ProductDetailID);

            value.ProductCheck = request.ProductCheck;
            value.ProductMinWeight = request.ProductMinWeight;
            value.ProductPrice = request.ProductPrice;
            value.ProductQuality = request.ProductQuality;
            value.ProductDescription = request.ProductDescription;
            value.ProductDetailName = request.ProductDetailName;
            value.ProductID = request.ProductID;
            value.ProductOrigin = request.ProductOrigin;
            value.ProductRating = request.ProductRating;
            value.ProductWeight = request.ProductWeight;

            await _repository.UpdateAsync(value);
        }
    }
}
