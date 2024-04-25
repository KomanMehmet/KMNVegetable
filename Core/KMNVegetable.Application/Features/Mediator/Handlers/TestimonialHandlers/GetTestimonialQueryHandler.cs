using KMNVegetable.Application.Features.Mediator.Queries.TestimonialQueries;
using KMNVegetable.Application.Features.Mediator.Results.TestimonialResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetTestimonialQueryResult
            {
                TestimonialDescription = x.TestimonialDescription,
                TestimonialID = x.TestimonialID,
                TestimonialName = x.TestimonialName,
                TestimonialRating = x.TestimonialRating
            }).ToList();
        }
    }
}
