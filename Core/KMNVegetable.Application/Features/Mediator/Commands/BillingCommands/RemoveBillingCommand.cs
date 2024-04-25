using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.BillingCommands
{
    public class RemoveBillingCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveBillingCommand(int id)
        {
            Id = id;
        }
    }
}
