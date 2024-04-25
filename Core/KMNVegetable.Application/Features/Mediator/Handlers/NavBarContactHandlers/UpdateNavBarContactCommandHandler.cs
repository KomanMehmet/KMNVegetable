using KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.NavBarContactHandlers
{
    public class UpdateNavBarContactCommandHandler : IRequestHandler<UpdateNavBarContactCommand>
    {
        private readonly IRepository<NavBarContact> _repository;

        public UpdateNavBarContactCommandHandler(IRepository<NavBarContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateNavBarContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.NavBarContactID);

            value.Email = request.Email;
            value.Address = request.Address;

            await _repository.UpdateAsync(value);
        }
    }
}
