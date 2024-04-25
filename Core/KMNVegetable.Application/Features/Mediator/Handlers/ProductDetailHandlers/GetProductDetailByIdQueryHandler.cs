using KMNVegetable.Application.Features.Mediator.Queries.ProductDetailQueries;
using KMNVegetable.Application.Features.Mediator.Results.ProductDetailResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductDetailHandlers
{
    public class GetProductDetailByIdQueryHandler : IRequestHandler<GetProductDetailByIdQuery, GetProductDetailByIdQueryResult>
    {
        private readonly IRepository<ProductDetail> _repository;

        public GetProductDetailByIdQueryHandler(IRepository<ProductDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductDetailByIdQueryResult> Handle(GetProductDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetProductDetailByIdQueryResult
            {
                ProductCheck = value.ProductCheck,
                ProductDescription = value.ProductDescription,
                ProductDetailID = value.ProductDetailID,
                ProductDetailName = value.ProductDetailName,
                ProductID = value.ProductID,
                ProductMinWeight = value.ProductMinWeight,
                ProductOrigin = value.ProductOrigin,
                ProductPrice = value.ProductPrice,
                ProductQuality = value.ProductQuality,
                ProductRating = value.ProductRating,
                ProductWeight = value.ProductWeight
            };
        }
    }
}
