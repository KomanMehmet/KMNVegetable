using KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.NavBarContactHandlers
{
    public class RemoveNavBarContactCommandHandler : IRequestHandler<RemoveNavBarContactCommand>
    {
        private readonly IRepository<NavBarContact> _repository;

        public RemoveNavBarContactCommandHandler(IRepository<NavBarContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveNavBarContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
