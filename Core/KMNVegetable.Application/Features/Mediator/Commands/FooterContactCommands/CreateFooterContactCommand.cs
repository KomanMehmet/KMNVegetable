using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands
{
    public class CreateFooterContactCommand : IRequest
    {
        public string FooterContactAddress { get; set; }

        public string FooterContactEmail { get; set; }

        public string FooterContactPhoneNumber { get; set; }
    }
}
