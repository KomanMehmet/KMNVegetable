using KMNVegetable.Application.Features.Mediator.Queries.FooterQueries;
using KMNVegetable.Application.Features.Mediator.Results.FooterResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class GetFooterByIdQueryHandler : IRequestHandler<GetFooterByIdQuery, GetFooterByIdQueryResult>
    {
        private readonly IRepository<Footer> _repository;

        public GetFooterByIdQueryHandler(IRepository<Footer> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterByIdQueryResult> Handle(GetFooterByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetFooterByIdQueryResult
            {
                FooterID = value.FooterID,
                FooterNote = value.FooterNote,
                FooterSubtitle = value.FooterSubtitle,
                FooterSubtitleDescription = value.FooterSubtitleDescription,
                FooterTitle1 = value.FooterTitle1,
                FooterTitle2 = value.FooterTitle2
            };
        }
    }
}
