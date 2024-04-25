using KMNVegetable.Application.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {
    }
}
