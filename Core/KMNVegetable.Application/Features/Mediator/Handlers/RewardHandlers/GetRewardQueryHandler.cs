using KMNVegetable.Application.Features.Mediator.Queries.RewardQueries;
using KMNVegetable.Application.Features.Mediator.Results.RewardResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.RewardHandlers
{
    public class GetRewardQueryHandler : IRequestHandler<GetRewardQuery, List<GetRewardQueryResult>>
    {
        private readonly IRepository<Reward> _repository;

        public GetRewardQueryHandler(IRepository<Reward> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRewardQueryResult>> Handle(GetRewardQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetRewardQueryResult
            {
                RewardID = x.RewardID,
                RewardRate = x.RewardRate,
                RewardTitle = x.RewardTitle
            }).ToList();
        }
    }
}
