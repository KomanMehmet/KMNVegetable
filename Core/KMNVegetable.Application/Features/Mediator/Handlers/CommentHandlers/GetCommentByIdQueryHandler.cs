using KMNVegetable.Application.Features.Mediator.Queries.CommentQueries;
using KMNVegetable.Application.Features.Mediator.Results.CommentResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentByIdQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<GetCommentByIdQueryResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return new GetCommentByIdQueryResult
            {
                CommentID = value.CommentID,
                Email = value.Email,
                Name = value.Name,
                ProductID = value.ProductID,
                Rating = value.Rating,
                Review = value.Review   
            };
        }
    }
}
