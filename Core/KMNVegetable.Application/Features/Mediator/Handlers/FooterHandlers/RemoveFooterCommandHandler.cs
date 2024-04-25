
using KMNVegetable.Application.Features.Mediator.Commands.FooterCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class RemoveFooterCommandHandler : IRequestHandler<RemoveFooterCommand>
    {
        private readonly IRepository<Footer> _repository;

        public RemoveFooterCommandHandler(IRepository<Footer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFooterCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
