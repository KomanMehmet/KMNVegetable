using KMNVegetable.Application.Features.Mediator.Results.MainSliderResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.MainSliderQueries
{
    public class GetMainSliderByIdQuery : IRequest<GetMainSliderByIdQueryResult>
    {
        public int Id { get; set; }

        public GetMainSliderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
