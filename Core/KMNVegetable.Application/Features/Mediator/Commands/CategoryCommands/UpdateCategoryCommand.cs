using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
