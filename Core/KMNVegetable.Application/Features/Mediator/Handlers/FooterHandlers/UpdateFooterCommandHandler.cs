using KMNVegetable.Application.Features.Mediator.Commands.FooterCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class UpdateFooterCommandHandler : IRequestHandler<UpdateFooterCommand>
    {
        private readonly IRepository<Footer> _repository;

        public UpdateFooterCommandHandler(IRepository<Footer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterID);

            value.FooterSubtitleDescription = request.FooterSubtitleDescription;
            value.FooterSubtitle = request.FooterSubtitle;
            value.FooterTitle1 = request.FooterTitle1;
            value.FooterTitle2 = request.FooterTitle2;
            value.FooterNote = request.FooterNote;

            await _repository.UpdateAsync(value);
        }
    }
}
