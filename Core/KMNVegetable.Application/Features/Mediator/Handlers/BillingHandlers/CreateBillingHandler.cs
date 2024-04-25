using KMNVegetable.Application.Features.Mediator.Commands.BillingCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BillingHandlers
{
    public class CreateBillingHandler : IRequestHandler<CreateBillingCommand>
    {
        private readonly IRepository<Billing> _repository;

        public CreateBillingHandler(IRepository<Billing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBillingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Billing
            {
                Address = request.Address,
                Annotation = request.Annotation,
                City = request.City,
                Country = request.Country,
                Email = request.Email,
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                Postcode = request.Postcode,
                Surname = request.Surname
            });
        }
    }
}
