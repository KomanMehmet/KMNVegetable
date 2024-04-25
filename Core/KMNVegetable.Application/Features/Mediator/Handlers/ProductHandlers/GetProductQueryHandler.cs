using KMNVegetable.Application.Features.Mediator.Queries.ProductQueries;
using KMNVegetable.Application.Features.Mediator.Results.ProductResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetProductQueryResult
            {
                CategoryID = x.CategoryID,
                ProductDescription = x.ProductDescription,
                ProductName = x.ProductName,
                ProductID = x.ProductID,
                ProductImageUrl = x.ProductImageUrl,
                ProductPrice = x.ProductPrice,
                TotalProductPrice = x.TotalProductPrice
            }).ToList();
        }
    }
}
