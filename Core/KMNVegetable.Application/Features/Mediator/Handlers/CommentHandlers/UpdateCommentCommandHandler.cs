using KMNVegetable.Application.Features.Mediator.Commands.CommentCommands;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public UpdateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CommentID);

            value.Review = request.Review;
            value.ProductID = request.ProductID;
            value.Email = request.Email;
            value.Name = request.Name;
            value.Rating = request.Rating;

            await _repository.UpdateAsync(value);
        }
    }
}
