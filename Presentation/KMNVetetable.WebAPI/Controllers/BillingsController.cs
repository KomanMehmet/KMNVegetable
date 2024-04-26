using KMNVegetable.Application.Features.Mediator.Commands.BillingCommands;
using KMNVegetable.Application.Features.Mediator.Queries.BillingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BillingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BillingList()
        {
            var values = await _mediator.Send(new GetBillingQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillingById(int id)
        {
            var values = await _mediator.Send(new GetBillingByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBilling(CreateBillingCommand command)
        {
            await _mediator.Send(command);

            return Ok("Billing Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBilling(int id)
        {
            await _mediator.Send(new RemoveBillingCommand(id));

            return Ok("Billing Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBilling(UpdateBillingCommand command)
        {
            await _mediator.Send(command);

            return Ok("Billing Güncellendi");
        }
    }
}
