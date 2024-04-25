using KMNVegetable.Application.Features.Mediator.Queries.NavBarContactQueries;
using KMNVegetable.Application.Features.Mediator.Results.NavBarContactResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.NavBarContactHandlers
{
    public class GetNavBarContactQueryHandler : IRequestHandler<GetNavBarContactQuery, List<GetNavBarContactQueryResult>>
    {
        private readonly IRepository<NavBarContact> _repository;

        public GetNavBarContactQueryHandler(IRepository<NavBarContact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetNavBarContactQueryResult>> Handle(GetNavBarContactQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetNavBarContactQueryResult
            {
                Address = x.Address,
                Email = x.Email,
                NavBarContactID = x.NavBarContactID
            }).ToList();
        }
    }
}
