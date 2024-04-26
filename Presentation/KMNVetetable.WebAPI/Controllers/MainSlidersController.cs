using KMNVegetable.Application.Features.Mediator.Commands.MainSliderCommands;
using KMNVegetable.Application.Features.Mediator.Queries.MainSliderQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainSlidersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MainSlidersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> MainSliderList()
        {
            var values = await _mediator.Send(new GetMainSliderQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMainSliderById(int id)
        {
            var values = await _mediator.Send(new GetMainSliderByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMainSlider(CreateMainSliderCommand command)
        {
            await _mediator.Send(command);

            return Ok("MainSlider Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMainSlider(int id)
        {
            await _mediator.Send(new RemoveMainSliderCommand(id));

            return Ok("MainSlider Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMainSlider(UpdateMainSliderCommand command)
        {
            await _mediator.Send(command);

            return Ok("MainSlider Güncellendi");
        }
    }
}
