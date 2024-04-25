using KMNVegetable.Application.Features.Mediator.Queries.DiscountQueries;
using KMNVegetable.Application.Features.Mediator.Results.DiscountResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.DiscountHandlers
{
    public class GetDiscountByIdQueryHandler : IRequestHandler<GetDiscountByIdQuery, GetDiscountByIdQueryResult>
    {
        private readonly IRepository<Discount> _repository;

        public GetDiscountByIdQueryHandler(IRepository<Discount> repository)
        {
            _repository = repository;
        }

        public async Task<GetDiscountByIdQueryResult> Handle(GetDiscountByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetDiscountByIdQueryResult
            {
                DiscoundProductAmount = value.DiscoundProductAmount,
                DiscoundProductName = value.DiscoundProductName,
                DiscountID = value.DiscountID,
                ProductID = value.ProductID 
            };
        }
    }
}
