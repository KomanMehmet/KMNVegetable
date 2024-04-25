using KMNVegetable.Application.Features.Mediator.Commands.MainSliderCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.MainSliderHandlers
{
    public class CreateMainSliderCommandHandler : IRequestHandler<CreateMainSliderCommand>
    {
        private readonly IRepository<MainSlider> _repository;

        public CreateMainSliderCommandHandler(IRepository<MainSlider> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMainSliderCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new MainSlider
            {
                Description = request.Description,
                SliderImageUrl1 = request.SliderImageUrl1,
                SliderImageUrl2 = request.SliderImageUrl2,
                Title = request.Title
            });
        }
    }
}
