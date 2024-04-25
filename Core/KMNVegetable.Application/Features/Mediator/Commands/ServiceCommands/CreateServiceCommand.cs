using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.ServiceCommands
{
    public class CreateServiceCommand : IRequest
    {
        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }
    }
}
