using KMNVegetable.Application.Features.Mediator.Results.FooterResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.FooterQueries
{
    public class GetFooterQuery : IRequest<List<GetFooterQueryResult>>
    {
    }
}
