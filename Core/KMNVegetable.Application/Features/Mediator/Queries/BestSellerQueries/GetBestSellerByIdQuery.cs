using KMNVegetable.Application.Features.Mediator.Results.BestSellerResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.BestSellerQueries
{
    public class GetBestSellerByIdQuery : IRequest<GetBestSellerByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBestSellerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
