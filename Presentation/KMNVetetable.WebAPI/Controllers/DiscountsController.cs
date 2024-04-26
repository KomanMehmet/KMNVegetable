using KMNVegetable.Application.Features.Mediator.Commands.DiscountCommands;
using KMNVegetable.Application.Features.Mediator.Queries.DiscountQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DiscountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountList()
        {
            var values = await _mediator.Send(new GetDiscountQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountById(int id)
        {
            var values = await _mediator.Send(new GetDiscountByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountCommand command)
        {
            await _mediator.Send(command);

            return Ok("Discount Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveDiscount(int id)
        {
            await _mediator.Send(new RemoveDiscountCommand(id));

            return Ok("Discount Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountCommand command)
        {
            await _mediator.Send(command);

            return Ok("Discount Güncellendi");
        }
    }
}
