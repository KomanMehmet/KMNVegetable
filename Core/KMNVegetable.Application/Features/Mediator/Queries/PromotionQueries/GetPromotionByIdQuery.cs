using KMNVegetable.Application.Features.Mediator.Results.PromotionResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.PromotionQueries
{
    public class GetPromotionByIdQuery : IRequest<GetPromotionByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPromotionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
