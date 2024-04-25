using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.MainSliderCommands
{
    public class UpdateMainSliderCommand : IRequest
    {
        public int MainSliderID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string SliderImageUrl1 { get; set; }

        public string SliderImageUrl2 { get; set; }
    }
}
