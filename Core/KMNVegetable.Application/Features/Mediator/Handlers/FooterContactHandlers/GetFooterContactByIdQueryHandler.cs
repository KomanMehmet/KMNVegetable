using KMNVegetable.Application.Features.Mediator.Queries.FooterContactQueries;
using KMNVegetable.Application.Features.Mediator.Results.FooterContactResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterContactHandlers
{
    public class GetFooterContactByIdQueryHandler : IRequestHandler<GetFooterContactByIdQuery, GetFooterContactByIdQueryResult>
    {
        private readonly IRepository<FooterContact> _repository;

        public GetFooterContactByIdQueryHandler(IRepository<FooterContact> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterContactByIdQueryResult> Handle(GetFooterContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetFooterContactByIdQueryResult
            {
                FooterContactAddress = value.FooterContactAddress,
                FooterContactEmail = value.FooterContactEmail,
                FooterContactID = value.FooterContactID,
                FooterContactPhoneNumber = value.FooterContactPhoneNumber
            };
        }
    }
}
