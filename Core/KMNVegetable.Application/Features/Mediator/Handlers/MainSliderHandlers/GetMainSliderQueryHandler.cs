using KMNVegetable.Application.Features.Mediator.Queries.MainSliderQueries;
using KMNVegetable.Application.Features.Mediator.Results.MainSliderResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.MainSliderHandlers
{
    public class GetMainSliderQueryHandler : IRequestHandler<GetMainSliderQuery, List<GetMainSliderQueryResult>>
    {
        private readonly IRepository<MainSlider> _repository;

        public GetMainSliderQueryHandler(IRepository<MainSlider> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMainSliderQueryResult>> Handle(GetMainSliderQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetMainSliderQueryResult
            {
                Description = x.Description,
                MainSliderID = x.MainSliderID,
                SliderImageUrl1 = x.SliderImageUrl1,
                SliderImageUrl2 = x.SliderImageUrl2,
                Title = x.Title
            }).ToList();
        }
    }
}
