using KMNVegetable.Application.Features.Mediator.Commands.ProductDetailCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ProductDetailHandlers
{
    public class RemoveProductDetailCommandHandler : IRequestHandler<RemoveProductDetailCommand>
    {
        private readonly IRepository<ProductDetail> _repository;

        public RemoveProductDetailCommandHandler(IRepository<ProductDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
