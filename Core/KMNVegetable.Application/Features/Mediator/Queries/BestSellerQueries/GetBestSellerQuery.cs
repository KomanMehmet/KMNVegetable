using KMNVegetable.Application.Features.Mediator.Results.BestSellerResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.BestSellerQueries
{
    public class GetBestSellerQuery : IRequest<List<GetBestSellerQueryResult>>
    {
    }
}
