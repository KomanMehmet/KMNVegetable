using KMNVegetable.Application.Features.Mediator.Queries.BestSellerQueries;
using KMNVegetable.Application.Features.Mediator.Results.BestSellerResults;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BestSellerHandlers
{
    public class GetBestSellerQueryHandler : IRequestHandler<GetBestSellerQuery, List<GetBestSellerQueryResult>>
    {
        private readonly IRepository<BestSeller> _repository;

        public GetBestSellerQueryHandler(IRepository<BestSeller> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBestSellerQueryResult>> Handle(GetBestSellerQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetBestSellerQueryResult
            {
                BestSellerID = x.BestSellerID,
                BestSellerProductName = x.BestSellerProductName,
                Price = x.Price,
                ProductID = x.ProductID,
                Rating = x.Rating
            }).ToList();
        }
    }
}
