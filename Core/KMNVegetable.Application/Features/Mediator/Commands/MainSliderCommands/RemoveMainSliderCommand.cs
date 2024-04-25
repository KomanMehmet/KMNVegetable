using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.MainSliderCommands
{
    public class RemoveMainSliderCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveMainSliderCommand(int id)
        {
            Id = id;
        }
    }
}
