using KMNVegetable.Application.Features.Mediator.Results.FooterContactResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.FooterContactQueries
{
    public class GetFooterContactByIdQuery : IRequest<GetFooterContactByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFooterContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}
