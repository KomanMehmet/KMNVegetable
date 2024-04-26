using KMNVegetable.Application.Features.Mediator.Commands.NavBarContactCommands;
using KMNVegetable.Application.Features.Mediator.Queries.NavBarContactQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavBarContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NavBarContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> NavBarContactList()
        {
            var values = await _mediator.Send(new GetNavBarContactQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNavBarContactById(int id)
        {
            var values = await _mediator.Send(new GetNavBarContactByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNavBarContact(CreateNavBarContactCommand command)
        {
            await _mediator.Send(command);

            return Ok("NavBarContact Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveNavBarContact(int id)
        {
            await _mediator.Send(new RemoveNavBarContactCommand(id));

            return Ok("NavBarContact Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNavBarContact(UpdateNavBarContactCommand command)
        {
            await _mediator.Send(command);

            return Ok("NavBarContact Güncellendi");
        }
    }
}
