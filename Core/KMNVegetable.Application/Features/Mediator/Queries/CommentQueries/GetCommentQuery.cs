using KMNVegetable.Application.Features.Mediator.Results.CommentResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentQuery : IRequest<List<GetCommentQueryResult>>
    {
    }
}
