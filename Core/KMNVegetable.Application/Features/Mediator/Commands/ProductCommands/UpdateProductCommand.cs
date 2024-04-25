using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.ProductCommands
{
    public class UpdateProductCommand : IRequest
    {
        public int ProductID { get; set; }

        public string ProductImageUrl { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal TotalProductPrice { get; set; }

        public int CategoryID { get; set; }
    }
}
