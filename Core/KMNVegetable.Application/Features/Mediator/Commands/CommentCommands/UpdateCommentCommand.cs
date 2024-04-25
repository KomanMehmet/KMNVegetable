using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Commands.CommentCommands
{
    public class UpdateCommentCommand : IRequest
    {
        public int CommentID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public int ProductID { get; set; }
    }
}
