using KMNVegetable.Application.Features.Mediator.Results.BillingResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.BillingQueries
{
    public class GetBillingByIdQuery : IRequest<GetBillingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBillingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
