using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest
    {
        public string CategoryName { get; set; }
    }
}
