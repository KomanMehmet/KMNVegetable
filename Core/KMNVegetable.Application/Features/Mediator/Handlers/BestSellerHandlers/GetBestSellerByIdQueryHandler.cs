
using KMNVegetable.Application.Features.Mediator.Queries.BestSellerQueries;
using KMNVegetable.Application.Features.Mediator.Results.BestSellerResults;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BestSellerHandlers
{
    public class GetBestSellerByIdQueryHandler : IRequestHandler<GetBestSellerByIdQuery, GetBestSellerByIdQueryResult>
    {
        private readonly IRepository<BestSeller> _repository;

        public GetBestSellerByIdQueryHandler(IRepository<BestSeller> repository)
        {
            _repository = repository;
        }

        public async Task<GetBestSellerByIdQueryResult> Handle(GetBestSellerByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetBestSellerByIdQueryResult
            {
                BestSellerID = value.BestSellerID,
                BestSellerProductName = value.BestSellerProductName,
                Price = value.Price,
                ProductID = value.ProductID,
                Rating = value.Rating   
            };
        }
    }
}
