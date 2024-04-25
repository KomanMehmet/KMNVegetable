using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.PromotionCommands
{
    public class UpdatePromotionCommand : IRequest
    {
        public int PromotionID { get; set; }

        public string PromotionTitle1 { get; set; }

        public string PromotionTitle2 { get; set; }

        public string PromotionDescripiton { get; set; }

        public string PromotionImageUrl { get; set; }

        public decimal PromotionPrice { get; set; }
    }
}
