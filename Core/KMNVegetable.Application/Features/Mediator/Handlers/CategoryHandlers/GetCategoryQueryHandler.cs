using KMNVegetable.Application.Features.Mediator.Queries.CategoryQueries;
using KMNVegetable.Application.Features.Mediator.Results.CategoryResults;
using KMNVegetable.Application.Interfaces;
using KMNVegetable.Domain.Entities;
using MediatR;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVegetable.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
