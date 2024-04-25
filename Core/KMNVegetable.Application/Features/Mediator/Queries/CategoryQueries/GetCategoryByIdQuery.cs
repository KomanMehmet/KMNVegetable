using KMNVegetable.Application.Features.Mediator.Results.CategoryResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
