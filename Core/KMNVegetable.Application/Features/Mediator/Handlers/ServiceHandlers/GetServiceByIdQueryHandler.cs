using KMNVegetable.Application.Features.Mediator.Queries.ServiceQueries;
using KMNVegetable.Application.Features.Mediator.Results.ServiceResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetServiceByIdQueryResult
            {
                ServiceDescription = value.ServiceDescription,
                ServiceID = value.ServiceID,
                ServiceName = value.ServiceName
            };
        }
    }
}
