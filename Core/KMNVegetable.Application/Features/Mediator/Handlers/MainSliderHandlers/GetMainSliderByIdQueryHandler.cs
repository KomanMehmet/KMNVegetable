using KMNVegetable.Application.Features.Mediator.Queries.MainSliderQueries;
using KMNVegetable.Application.Features.Mediator.Results.MainSliderResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.MainSliderHandlers
{
    public class GetMainSliderByIdQueryHandler : IRequestHandler<GetMainSliderByIdQuery, GetMainSliderByIdQueryResult>
    {
        private readonly IRepository<MainSlider> _repository;

        public GetMainSliderByIdQueryHandler(IRepository<MainSlider> repository)
        {
            _repository = repository;
        }

        public async Task<GetMainSliderByIdQueryResult> Handle(GetMainSliderByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetMainSliderByIdQueryResult
            {
                Description = value.Description,
                MainSliderID = value.MainSliderID,
                SliderImageUrl1 = value.SliderImageUrl1,
                SliderImageUrl2 = value.SliderImageUrl2,
                Title = value.Title
            };
        }
    }
}
