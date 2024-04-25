using KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterContactHandlers
{
    public class CreateFooterContactCommandHandler : IRequestHandler<CreateFooterContactCommand>
    {
        private readonly IRepository<FooterContact> _repository;

        public CreateFooterContactCommandHandler(IRepository<FooterContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterContact
            {
                FooterContactAddress = request.FooterContactAddress,
                FooterContactEmail = request.FooterContactEmail,
                FooterContactPhoneNumber = request.FooterContactPhoneNumber
            });
        }
    }
}
