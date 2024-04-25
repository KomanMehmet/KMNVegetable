using KMNVegetable.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
