using KMNVegetable.Application.Features.Mediator.Results.PromotionResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.PromotionQueries
{
    public class GetPromotionQuery : IRequest<List<GetPromotionQueryResult>>
    {
    }
}
