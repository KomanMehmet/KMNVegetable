using KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterContactHandlers
{
    public class UpdateFooterContactCommandHandler : IRequestHandler<UpdateFooterContactCommand>
    {
        private readonly IRepository<FooterContact> _repository;

        public UpdateFooterContactCommandHandler(IRepository<FooterContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterContactID);

            value.FooterContactPhoneNumber = request.FooterContactPhoneNumber;
            value.FooterContactEmail = request.FooterContactEmail;
            value.FooterContactAddress = request.FooterContactAddress;

            await _repository.UpdateAsync(value);
        }
    }
}
