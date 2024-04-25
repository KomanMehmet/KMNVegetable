using KMNVegetable.Application.Features.Mediator.Commands.ProductCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly IRepository<Product> _Repository;

        public RemoveProductCommandHandler(IRepository<Product> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _Repository.GetByIdAsync(request.Id);

            await _Repository.DeleteAsync(value);
        }
    }
}
