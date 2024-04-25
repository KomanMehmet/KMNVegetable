using KMNVegetable.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
