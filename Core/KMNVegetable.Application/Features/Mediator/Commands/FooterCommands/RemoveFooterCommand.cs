using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.FooterCommands
{
    public class RemoveFooterCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFooterCommand(int id)
        {
            Id = id;
        }
    }
}
