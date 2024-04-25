using KMNVegetable.Application.Features.Mediator.Queries.PromotionQueries;
using KMNVegetable.Application.Features.Mediator.Results.PromotionResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.PromotionHandlers
{
    public class GetPromotionByIdQueryHandler : IRequestHandler<GetPromotionByIdQuery, GetPromotionByIdQueryResult>
    {
        private readonly IRepository<Promotion> _repository;

        public GetPromotionByIdQueryHandler(IRepository<Promotion> repository)
        {
            _repository = repository;
        }

        public async Task<GetPromotionByIdQueryResult> Handle(GetPromotionByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetPromotionByIdQueryResult
            {
                PromotionDescripiton = value.PromotionDescripiton,
                PromotionID = value.PromotionID,
                PromotionImageUrl = value.PromotionImageUrl,
                PromotionPrice = value.PromotionPrice,
                PromotionTitle1 = value.PromotionTitle1,
                PromotionTitle2 = value.PromotionTitle2
            };
        }
    }
}
