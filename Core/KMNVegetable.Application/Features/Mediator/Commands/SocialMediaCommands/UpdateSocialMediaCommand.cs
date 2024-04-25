using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class UpdateSocialMediaCommand : IRequest
    {
        public int SocialMediaID { get; set; }

        public string SocialMedyaName { get; set; }

        public string SocialMediaIcon { get; set; }
    }
}
