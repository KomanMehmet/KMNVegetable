using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands
{
    public class UpdateFooterContactCommand : IRequest
    {
        public int FooterContactID { get; set; }

        public string FooterContactAddress { get; set; }

        public string FooterContactEmail { get; set; }

        public string FooterContactPhoneNumber { get; set; }
    }
}
