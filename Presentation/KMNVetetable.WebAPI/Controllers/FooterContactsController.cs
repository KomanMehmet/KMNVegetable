using KMNVegetable.Application.Features.Mediator.Commands.FooterContactCommands;
using KMNVegetable.Application.Features.Mediator.Queries.FooterContactQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FooterContactList()
        {
            var values = await _mediator.Send(new GetFooterContactQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterContactById(int id)
        {
            var values = await _mediator.Send(new GetFooterContactByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterContact(CreateFooterContactCommand command)
        {
            await _mediator.Send(command);

            return Ok("FooterContact Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFooterContact(int id)
        {
            await _mediator.Send(new RemoveFooterContactCommand(id));

            return Ok("FooterContact Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterContact(UpdateFooterContactCommand command)
        {
            await _mediator.Send(command);

            return Ok("FooterContact Güncellendi");
        }
    }
}
