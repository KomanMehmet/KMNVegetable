using KMNVegetable.Application.Features.Mediator.Results.ProductDetailResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.ProductDetailQueries
{
    public class GetProductDetailQuery : IRequest<List<GetProductDetailQueryResult>>
    {
    }
}
