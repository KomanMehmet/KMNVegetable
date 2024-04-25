using KMNVegetable.Application.Features.Mediator.Queries.FooterContactQueries;
using KMNVegetable.Application.Features.Mediator.Results.FooterContactResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterContactHandlers
{
    public class GetFooterContactQueryHandler : IRequestHandler<GetFooterContactQuery, List<GetFooterContactQueryResult>>
    {
        private readonly IRepository<FooterContact> _repository;

        public GetFooterContactQueryHandler(IRepository<FooterContact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterContactQueryResult>> Handle(GetFooterContactQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetFooterContactQueryResult
            {
                FooterContactAddress = x.FooterContactAddress,
                FooterContactEmail = x.FooterContactEmail,
                FooterContactID = x.FooterContactID,
                FooterContactPhoneNumber = x.FooterContactPhoneNumber
            }).ToList();
        }
    }
}
