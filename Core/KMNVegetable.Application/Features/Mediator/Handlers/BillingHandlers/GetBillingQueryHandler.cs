using KMNVegetable.Application.Features.Mediator.Queries.BillingQueries;
using KMNVegetable.Application.Features.Mediator.Results.BillingResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.BillingHandlers
{
    public class GetBillingQueryHandler : IRequestHandler<GetBillingQuery, List<GetBillingQueryResult>>
    {
        private readonly IRepository<Billing> _repository;

        public GetBillingQueryHandler(IRepository<Billing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBillingQueryResult>> Handle(GetBillingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetBillingQueryResult
            {
                Address = x.Address,
                Annotation = x.Annotation,
                BillingID = x.BillingID,    
                City = x.City,
                Country = x.Country,
                Email = x.Email,
                Name = x.Name,
                PhoneNumber = x.PhoneNumber,
                Postcode = x.Postcode,
                Surname = x.Surname
            }).ToList();
        }
    }
}
