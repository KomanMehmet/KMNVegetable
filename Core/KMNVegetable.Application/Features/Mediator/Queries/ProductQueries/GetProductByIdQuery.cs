using KMNVegetable.Application.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
