using KMNVegetable.Application.Features.Mediator.Results.ProductDetailResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.ProductDetailQueries
{
    public class GetProductDetailByIdQuery : IRequest<GetProductDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
