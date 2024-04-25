﻿
using KMNVegetable.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace KMNVegetable.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}
