
using KMNVegetable.Application.Features.Mediator.Queries.TestimonialQueries;
using KMNVegetable.Application.Features.Mediator.Results.TestimonialResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetTestimonialByIdQueryResult
            {
                TestimonialDescription = value.TestimonialDescription,
                TestimonialID = value.TestimonialID,
                TestimonialName = value.TestimonialName,
                TestimonialRating = value.TestimonialRating
            };
        }
    }
}
