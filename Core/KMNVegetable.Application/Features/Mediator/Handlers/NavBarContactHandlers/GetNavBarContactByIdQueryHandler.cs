using KMNVegetable.Application.Features.Mediator.Queries.NavBarContactQueries;
using KMNVegetable.Application.Features.Mediator.Results.NavBarContactResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.NavBarContactHandlers
{
    public class GetNavBarContactByIdQueryHandler : IRequestHandler<GetNavBarContactByIdQuery, GetNavBarContactByIdQueryResult>
    {
        private readonly IRepository<NavBarContact> _repostiroy;

        public GetNavBarContactByIdQueryHandler(IRepository<NavBarContact> repostiroy)
        {
            _repostiroy = repostiroy;
        }

        public async Task<GetNavBarContactByIdQueryResult> Handle(GetNavBarContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repostiroy.GetByIdAsync(request.Id);

            return new GetNavBarContactByIdQueryResult
            {
                Address = value.Address,
                Email = value.Email,
                NavBarContactID = value.NavBarContactID
            };
        }
    }
}
