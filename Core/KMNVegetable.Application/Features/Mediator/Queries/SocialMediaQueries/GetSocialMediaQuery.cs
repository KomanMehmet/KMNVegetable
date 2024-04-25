using KMNVegetable.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
