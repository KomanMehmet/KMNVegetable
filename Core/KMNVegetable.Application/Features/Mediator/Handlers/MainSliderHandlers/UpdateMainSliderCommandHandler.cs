using KMNVegetable.Application.Features.Mediator.Commands.MainSliderCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.MainSliderHandlers
{
    public class UpdateMainSliderCommandHandler : IRequestHandler<UpdateMainSliderCommand>
    {
        private readonly IRepository<MainSlider> _repository;

        public UpdateMainSliderCommandHandler(IRepository<MainSlider> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMainSliderCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.MainSliderID);

            value.Description = request.Description;
            value.Title = request.Title;
            value.SliderImageUrl1 = request.SliderImageUrl1;
            value.SliderImageUrl2 = request.SliderImageUrl2;

            await _repository.UpdateAsync(value);
        }
    }
}
