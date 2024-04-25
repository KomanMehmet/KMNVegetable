using KMNVegetable.Application.Features.Mediator.Queries.FooterQueries;
using KMNVegetable.Application.Features.Mediator.Results.FooterResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.FooterHandlers
{
    public class GetFooterQueryHandler : IRequestHandler<GetFooterQuery, List<GetFooterQueryResult>>
    {
        private readonly IRepository<Footer> _repository;

        public GetFooterQueryHandler(IRepository<Footer> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterQueryResult>> Handle(GetFooterQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetFooterQueryResult
            {
                FooterID = x.FooterID,
                FooterNote = x.FooterNote,
                FooterSubtitle = x.FooterSubtitle,
                FooterSubtitleDescription = x.FooterSubtitleDescription,
                FooterTitle1 = x.FooterTitle1,
                FooterTitle2 = x.FooterTitle2
            }).ToList();
        }
    }
}
