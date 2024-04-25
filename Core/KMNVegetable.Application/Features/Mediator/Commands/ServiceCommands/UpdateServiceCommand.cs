using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.ServiceCommands
{
    public class UpdateServiceCommand : IRequest
    {
        public int ServiceID { get; set; }

        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }
    }
}
