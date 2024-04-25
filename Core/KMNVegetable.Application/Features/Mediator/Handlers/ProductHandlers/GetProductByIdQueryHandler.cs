using KMNVegetable.Application.Features.Mediator.Queries.ProductQueries;
using KMNVegetable.Application.Features.Mediator.Results.ProductResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetProductByIdQueryResult
            {
                CategoryID = value.CategoryID,
                ProductID = value.ProductID,
                ProductDescription = value.ProductDescription,
                ProductImageUrl = value.ProductImageUrl,
                ProductName = value.ProductName,
                ProductPrice = value.ProductPrice,
                TotalProductPrice = value.TotalProductPrice
            };
        }
    }
}
