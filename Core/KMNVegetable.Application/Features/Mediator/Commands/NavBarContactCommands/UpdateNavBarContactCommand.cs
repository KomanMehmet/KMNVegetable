using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands
{
    public class UpdateNavBarContactCommand : IRequest
    {
        public int NavBarContactID { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
    }
}
