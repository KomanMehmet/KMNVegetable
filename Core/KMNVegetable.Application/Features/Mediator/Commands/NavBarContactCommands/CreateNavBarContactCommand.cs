using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands
{
    public class CreateNavBarContactCommand : IRequest
    {
        public string Address { get; set; }

        public string Email { get; set; }
    }
}
