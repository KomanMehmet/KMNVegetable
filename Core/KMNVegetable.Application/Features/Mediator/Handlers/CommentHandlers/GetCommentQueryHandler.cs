using KMNVegetable.Application.Features.Mediator.Queries.CommentQueries;
using KMNVegetable.Application.Features.Mediator.Results.CommentResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCommentQueryResult
            {
                CommentID = x.CommentID,
                Email = x.Email,
                Name = x.Name,
                ProductID = x.ProductID,
                Rating = x.Rating,
                Review = x.Review
            }).ToList();
        }
    }
}
