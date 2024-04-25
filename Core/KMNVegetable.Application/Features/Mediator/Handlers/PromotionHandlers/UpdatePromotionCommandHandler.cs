using KMNVegetable.Application.Features.Mediator.Commands.PromotionCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.PromotionHandlers
{
    public class UpdatePromotionCommandHandler : IRequestHandler<UpdatePromotionCommand>
    {
        private readonly IRepository<Promotion> _repository;

        public UpdatePromotionCommandHandler(IRepository<Promotion> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePromotionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.PromotionID);

            value.PromotionDescripiton = request.PromotionDescripiton;
            value.PromotionPrice = request.PromotionPrice;
            value.PromotionTitle1 = request.PromotionTitle1;
            value.PromotionTitle2 = request.PromotionTitle2;
            value.PromotionImageUrl = request.PromotionImageUrl;

            await _repository.UpdateAsync(value);
        }
    }
}
