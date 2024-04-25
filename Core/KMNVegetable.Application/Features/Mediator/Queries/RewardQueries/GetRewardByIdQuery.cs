using KMNVegetable.Application.Features.Mediator.Results.RewardResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.RewardQueries
{
    public class GetRewardByIdQuery : IRequest<GetRewardByIdQueryResult>
    {
        public int Id { get; set; }

        public GetRewardByIdQuery(int id)
        {
            Id = id;
        }
    }
}
