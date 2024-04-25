using KMNVegetable.Application.Features.Mediator.Results.BillingResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.BillingQueries
{
    public class GetBillingQuery : IRequest<List<GetBillingQueryResult>>
    {
    }
}
