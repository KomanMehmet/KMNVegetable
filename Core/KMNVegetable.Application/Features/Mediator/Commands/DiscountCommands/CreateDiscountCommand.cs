using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands
{
    public class CreateDiscountCommand : IRequest
    {
        public string DiscoundProductName { get; set; }

        public string DiscoundProductAmount { get; set; }

        public int ProductID { get; set; }
    }
}
