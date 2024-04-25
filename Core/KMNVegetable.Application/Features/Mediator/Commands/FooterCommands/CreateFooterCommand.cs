using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.FooterCommands
{
    public class CreateFooterCommand : IRequest
    {
        public string FooterTitle1 { get; set; }

        public string FooterTitle2 { get; set; }

        public string FooterSubtitle { get; set; }

        public string FooterSubtitleDescription { get; set; }

        public string FooterNote { get; set; }
    }
}
