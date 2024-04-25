using KMNVegetable.Application.Features.Mediator.Queries.ProductDetailQueries;
using KMNVegetable.Application.Features.Mediator.Results.ProductDetailResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductDetailHandlers
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, List<GetProductDetailQueryResult>>
    {
        private readonly IRepository<ProductDetail> _repository;

        public GetProductDetailQueryHandler(IRepository<ProductDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductDetailQueryResult>> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetProductDetailQueryResult
            {
                ProductCheck = x.ProductCheck,
                ProductDescription = x.ProductDescription,
                ProductDetailID = x.ProductDetailID,
                ProductDetailName = x.ProductDetailName,
                ProductID = x.ProductID,
                ProductMinWeight = x.ProductMinWeight,
                ProductOrigin = x.ProductOrigin,
                ProductPrice = x.ProductPrice,
                ProductQuality = x.ProductQuality,
                ProductRating = x.ProductRating,
                ProductWeight = x.ProductWeight
            }).ToList();
        }
    }
}
