using KMNVegetable.Application.Features.Mediator.Results.DiscountResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.DiscountQueries
{
    public class GetDiscountByIdQuery : IRequest<GetDiscountByIdQueryResult>
    {
        public int Id { get; set; }

        public GetDiscountByIdQuery(int id)
        {
            Id = id;
        }
    }
}
