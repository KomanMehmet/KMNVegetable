using KMNVegetable.Application.Features.Mediator.Queries.BillingQueries;
using KMNVegetable.Application.Features.Mediator.Results.BillingResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BillingHandlers
{
    public class GetBillingByIdQueryHandler : IRequestHandler<GetBillingByIdQuery, GetBillingByIdQueryResult>
    {
        private readonly IRepository<Billing> _repository;

        public GetBillingByIdQueryHandler(IRepository<Billing> repository)
        {
            _repository = repository;
        }

        public async Task<GetBillingByIdQueryResult> Handle(GetBillingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetBillingByIdQueryResult
            {
                Address = value.Address,
                Annotation = value.Annotation,
                City = value.City,
                Country = value.Country,
                BillingID = value.BillingID,
                Email = value.Email,
                Name = value.Name,
                PhoneNumber = value.PhoneNumber,
                Postcode = value.Postcode,
                Surname = value.Surname
            };
        }
    }
}
