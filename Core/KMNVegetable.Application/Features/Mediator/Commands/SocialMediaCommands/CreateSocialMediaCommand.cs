using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class CreateSocialMediaCommand : IRequest
    {
        public string SocialMedyaName { get; set; }

        public string SocialMediaIcon { get; set; }
    }
}
