using KMNVegetable.Application.Features.Mediator.Queries.RewardQueries;
using KMNVegetable.Application.Features.Mediator.Results.RewardResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.RewardHandlers
{
    public class GetRewardByIdQueryHandler : IRequestHandler<GetRewardByIdQuery, GetRewardByIdQueryResult>
    {
        private readonly IRepository<Reward> _repository;

        public GetRewardByIdQueryHandler(IRepository<Reward> repository)
        {
            _repository = repository;
        }

        public async Task<GetRewardByIdQueryResult> Handle(GetRewardByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetRewardByIdQueryResult
            {
                RewardID = value.RewardID,
                RewardRate = value.RewardRate,
                RewardTitle = value.RewardTitle
            };
        }
    }
}
