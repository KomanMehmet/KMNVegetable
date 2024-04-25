using KMNVegetable.Application.Features.Mediator.Queries.ServiceQueries;
using KMNVegetable.Application.Features.Mediator.Results.ServiceResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetServiceQueryResult
            {
                ServiceDescription = x.ServiceDescription,
                ServiceID = x.ServiceID,
                ServiceName = x.ServiceName
            }).ToList();
        }
    }
}
