using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.ProductDetailCommands
{
    public class CreateProductDetailCommand : IRequest
    {
        public string ProductDetailName { get; set; }

        public int ProductID { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductRating { get; set; }

        public string ProductDescription { get; set; }

        public string ProductWeight { get; set; }

        public string ProductOrigin { get; set; }

        public string ProductQuality { get; set; }

        public string ProductCheck { get; set; }

        public string ProductMinWeight { get; set; }
    }
}
