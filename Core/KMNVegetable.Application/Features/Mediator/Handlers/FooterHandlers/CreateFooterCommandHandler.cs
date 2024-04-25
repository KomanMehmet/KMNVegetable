using KMNVegetable.Application.Features.Mediator.Commands.FooterCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class CreateFooterCommandHandler : IRequestHandler<CreateFooterCommand>
    {
        private readonly IRepository<Footer> _repository;

        public CreateFooterCommandHandler(IRepository<Footer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Footer
            {
                FooterNote = request.FooterNote,
                FooterSubtitle = request.FooterSubtitle,
                FooterSubtitleDescription = request.FooterSubtitleDescription,
                FooterTitle1 = request.FooterTitle1,
                FooterTitle2 = request.FooterTitle2
            });
        }
    }
}
