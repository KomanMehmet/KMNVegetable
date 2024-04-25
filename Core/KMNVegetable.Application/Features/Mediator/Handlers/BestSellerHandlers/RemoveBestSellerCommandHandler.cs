using KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BestSellerHandlers
{
    public class RemoveBestSellerCommandHandler : IRequestHandler<RemoveBestSellerCommand>
    {
        private readonly IRepository<BestSeller> _repository;

        public RemoveBestSellerCommandHandler(IRepository<BestSeller> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBestSellerCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
