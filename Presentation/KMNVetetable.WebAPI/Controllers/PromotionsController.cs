using KMNVegetable.Application.Features.Mediator.Commands.PromotionCommands;
using KMNVegetable.Application.Features.Mediator.Queries.PromotionQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PromotionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PromotionList()
        {
            var values = await _mediator.Send(new GetPromotionQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPromotionById(int id)
        {
            var values = await _mediator.Send(new GetPromotionByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePromotion(CreatePromotionCommand command)
        {
            await _mediator.Send(command);

            return Ok("Promotion Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePromotion(int id)
        {
            await _mediator.Send(new RemovePromotionCommand(id));

            return Ok("Promotion Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePromotion(UpdatePromotionCommand command)
        {
            await _mediator.Send(command);

            return Ok("Promotion Güncellendi");
        }
    }
}
