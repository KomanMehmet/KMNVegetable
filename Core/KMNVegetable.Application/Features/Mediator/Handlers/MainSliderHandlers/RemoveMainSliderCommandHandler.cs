using KMNVegetable.Application.Features.Mediator.Commands.MainSliderCommands;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Handlers.MainSliderHandlers
{
    public class RemoveMainSliderCommandHandler : IRequest<RemoveMainSliderCommand>
    {
        public int Id { get; set; }

        public RemoveMainSliderCommandHandler(int id)
        {
            Id = id;
        }
    }
}
