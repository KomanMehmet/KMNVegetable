using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands
{
    public class RemoveFooterContactCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFooterContactCommand(int id)
        {
            Id = id;
        }
    }
}
