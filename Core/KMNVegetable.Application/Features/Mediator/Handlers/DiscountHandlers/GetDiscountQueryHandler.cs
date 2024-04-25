using KMNVegetable.Application.Features.Mediator.Queries.DiscountQueries;
using KMNVegetable.Application.Features.Mediator.Results.DiscountResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.DiscountHandlers
{
    public class GetDiscountQueryHandler : IRequestHandler<GetDiscountQuery, List<GetDiscountQueryResult>>
    {
        private readonly IRepository<Discount> _repository;

        public GetDiscountQueryHandler(IRepository<Discount> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDiscountQueryResult>> Handle(GetDiscountQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetDiscountQueryResult
            {
                DiscoundProductAmount = x.DiscoundProductAmount,
                DiscoundProductName = x.DiscoundProductName,
                DiscountID = x.DiscountID,
                ProductID = x.ProductID
            }).ToList();
        }
    }
}
