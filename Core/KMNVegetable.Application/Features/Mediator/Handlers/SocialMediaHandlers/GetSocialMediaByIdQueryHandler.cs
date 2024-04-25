using KMNVegetable.Application.Features.Mediator.Queries.SocialMediaQueries;
using KMNVegetable.Application.Features.Mediator.Results.SocialMediaResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetSocialMediaByIdQueryResult
            {
                SocialMediaIcon = value.SocialMediaIcon,
                SocialMediaID = value.SocialMediaID,
                SocialMedyaName = value.SocialMedyaName
            };
        }
    }
}
