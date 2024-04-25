using KMNVegetable.Application.Features.Mediator.Results.DiscountResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.DiscountQueries
{
    public class GetDiscountQuery : IRequest<List<GetDiscountQueryResult>>
    {
    }
}
