using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class CreateTestimonialCommand : IRequest
    {
        public string TestimonialName { get; set; }

        public string TestimonialDescription { get; }

        public string TestimonialRating { get; set; }
    }
}
