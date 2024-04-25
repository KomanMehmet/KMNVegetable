using KMNVegetable.Application.Features.Mediator.Results.CategoryResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {
    }
}
