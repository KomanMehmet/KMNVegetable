using KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BestSellerHandlers
{
    public class UpdateBestSellerCommandHandler : IRequestHandler<UpdateBestSellerCommand>
    {
        private readonly IRepository<BestSeller> _repository;

        public UpdateBestSellerCommandHandler(IRepository<BestSeller> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBestSellerCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BestSellerID);

            values.BestSellerProductName = request.BestSellerProductName;
            values.Price = request.Price;
            values.ProductID = request.ProductID;
            values.Rating = request.Rating;

            await _repository.UpdateAsync(values);
        }
    }
}
