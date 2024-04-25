using KMNVegetable.Application.Features.Mediator.Queries.SocialMediaQueries;
using KMNVegetable.Application.Features.Mediator.Results.SocialMediaResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetSocialMediaQueryResult
            {
                SocialMediaIcon = x.SocialMediaIcon,
                SocialMediaID = x.SocialMediaID,
                SocialMedyaName = x.SocialMedyaName
            }).ToList();
        }
    }
}
