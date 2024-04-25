using KMNVegetable.Application.Features.Mediator.Queries.PromotionQueries;
using KMNVegetable.Application.Features.Mediator.Results.PromotionResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.PromotionHandlers
{
    public class GetPromotionQueryHandler : IRequestHandler<GetPromotionQuery, List<GetPromotionQueryResult>>
    {
        private readonly IRepository<Promotion> _repository;

        public GetPromotionQueryHandler(IRepository<Promotion> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPromotionQueryResult>> Handle(GetPromotionQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetPromotionQueryResult
            {
                PromotionDescripiton = x.PromotionDescripiton,
                PromotionID = x.PromotionID,
                PromotionImageUrl = x.PromotionImageUrl,
                PromotionPrice = x.PromotionPrice,
                PromotionTitle1 = x.PromotionTitle1,
                PromotionTitle2 = x.PromotionTitle2
            }).ToList();
        }
    }
}
