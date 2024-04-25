using KMNVegetable.Application.Features.Mediator.Results.RewardResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.RewardQueries
{
    public class GetRewardQuery : IRequest<List<GetRewardQueryResult>>
    {
    }
}
