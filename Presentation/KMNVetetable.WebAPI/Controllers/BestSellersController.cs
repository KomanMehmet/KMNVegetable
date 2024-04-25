using KMNVegetable.Application.Features.Mediator.Commands.BestSellerCommands;
using KMNVegetable.Application.Features.Mediator.Queries.BestSellerQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestSellersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BestSellersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BestSellerList()
        {
            var values = await _mediator.Send(new GetBestSellerQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBestSellerById(int id)
        {
            var values = await _mediator.Send(new GetBestSellerByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBestSeller(CreateBestSellerCommand command)
        {
            await _mediator.Send(command);

            return Ok("BestSeller Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBestSeller(int id)
        {
            await _mediator.Send(new RemoveBestSellerCommand(id));

            return Ok("BestSeller Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBestSeller(UpdateBestSellerCommand command)
        {
            await _mediator.Send(command);

            return Ok("BestSeller Güncellendi");
        }
    }
}
