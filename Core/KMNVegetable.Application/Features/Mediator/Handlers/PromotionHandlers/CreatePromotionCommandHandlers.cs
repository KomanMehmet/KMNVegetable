using KMNVegetable.Application.Features.Mediator.Commands.PromotionCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.PromotionHandlers
{
    public class CreatePromotionCommandHandlers : IRequestHandler<CreatePromotionCommand>
    {
        private readonly IRepository<Promotion> _repository;

        public CreatePromotionCommandHandlers(IRepository<Promotion> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePromotionCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Promotion
            {
                PromotionDescripiton = request.PromotionDescripiton,
                PromotionImageUrl = request.PromotionImageUrl,
                PromotionPrice = request.PromotionPrice,
                PromotionTitle1 = request.PromotionTitle1,
                PromotionTitle2 = request.PromotionTitle2
            });
        }
    }
}
