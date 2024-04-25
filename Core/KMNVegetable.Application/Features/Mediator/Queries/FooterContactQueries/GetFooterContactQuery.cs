
using KMNVegetable.Application.Features.Mediator.Results.FooterContactResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.FooterContactQueries
{
    public class GetFooterContactQuery : IRequest<List<GetFooterContactQueryResult>>
    {
    }
}
