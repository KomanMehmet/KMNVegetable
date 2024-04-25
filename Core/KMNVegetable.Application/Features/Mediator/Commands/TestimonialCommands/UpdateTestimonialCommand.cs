using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand : IRequest
    {
        public int TestimonialID { get; set; }

        public string TestimonialName { get; set; }

        public string TestimonialDescription { get; }

        public string TestimonialRating { get; set; }
    }
}
