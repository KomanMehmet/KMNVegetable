using KMNVegetable.Application.Features.Mediator.Results.MainSliderResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.MainSliderQueries
{
    public class GetMainSliderQuery : IRequest<List<GetMainSliderQueryResult>>
    {
    }
}
