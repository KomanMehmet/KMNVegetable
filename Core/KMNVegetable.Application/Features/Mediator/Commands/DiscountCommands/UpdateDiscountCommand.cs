using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands
{
    public class UpdateDiscountCommand : IRequest
    {
        public int DiscountID { get; set; }

        public string DiscoundProductName { get; set; }

        public string DiscoundProductAmount { get; set; }

        public int ProductID { get; set; }
    }
}
