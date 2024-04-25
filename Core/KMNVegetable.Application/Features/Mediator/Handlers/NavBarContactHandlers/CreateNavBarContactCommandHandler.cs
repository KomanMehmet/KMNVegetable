using KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.NavBarContactHandlers
{
    public class CreateNavBarContactCommandHandler : IRequestHandler<CreateNavBarContactCommand>
    {
        private readonly IRepository<NavBarContact> _repository;

        public CreateNavBarContactCommandHandler(IRepository<NavBarContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateNavBarContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new NavBarContact
            {
                Address = request.Address,
                Email = request.Email
            });
        }
    }
}
