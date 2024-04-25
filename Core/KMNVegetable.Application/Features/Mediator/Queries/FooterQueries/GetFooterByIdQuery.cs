using KMNVegetable.Application.Features.Mediator.Results.FooterResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.FooterQueries
{
    public class GetFooterByIdQuery : IRequest<GetFooterByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFooterByIdQuery(int id)
        {
            Id = id;
        }
    }
}
