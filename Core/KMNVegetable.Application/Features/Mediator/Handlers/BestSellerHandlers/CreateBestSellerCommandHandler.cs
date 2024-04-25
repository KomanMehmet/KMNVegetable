using KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BestSellerHandlers
{
    public class CreateBestSellerCommandHandler : IRequestHandler<CreateBestSellerCommand>
    {
        private readonly IRepository<BestSeller> _repository;

        public CreateBestSellerCommandHandler(IRepository<BestSeller> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBestSellerCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new BestSeller
            {
                BestSellerProductName = request.BestSellerProductName,
                Price = request.Price,
                ProductID = request.ProductID,
                Rating = request.Rating
            });
        }
    }
}
