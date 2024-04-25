using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands
{
    public class RemoveNavBarContactCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveNavBarContactCommand(int id)
        {
            Id = id;
        }
    }
}
