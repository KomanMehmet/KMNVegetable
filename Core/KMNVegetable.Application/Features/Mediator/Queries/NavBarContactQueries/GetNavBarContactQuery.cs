using KMNVegetable.Application.Features.Mediator.Results.NavBarContactResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.NavBarContactQueries
{
    public class GetNavBarContactQuery : IRequest<List<GetNavBarContactQueryResult>>
    {
    }
}
