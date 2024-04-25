using KMNVegetable.Application.Features.Mediator.Commands.BillingCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BillingHandlers
{
    public class UpdateBillingCommandHandler : IRequestHandler<UpdateBillingCommand>
    {
        private readonly IRepository<Billing> _repository;

        public UpdateBillingCommandHandler(IRepository<Billing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBillingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BillingID);

            value.Annotation = request.Annotation;
            value.Surname = request.Surname;
            value.Address = request.Address;
            value.City = request.City;
            value.Country = request.Country;
            value.Email = request.Email;
            value.Name = request.Name;
            value.PhoneNumber = request.PhoneNumber;
            value.Postcode = request.Postcode;
            
            await _repository.UpdateAsync(value);
        }
    }
}
