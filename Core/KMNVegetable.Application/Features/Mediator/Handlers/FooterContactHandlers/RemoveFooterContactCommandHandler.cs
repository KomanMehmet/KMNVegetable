using KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterContactHandlers
{
    public class RemoveFooterContactCommandHandler : IRequestHandler<RemoveFooterContactCommand>
    {
        private readonly IRepository<FooterContact> _repository;

        public RemoveFooterContactCommandHandler(IRepository<FooterContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFooterContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.DeleteAsync(value);
        }
    }
}
