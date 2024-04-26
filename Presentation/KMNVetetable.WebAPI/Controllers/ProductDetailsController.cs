using KMNVegetable.Application.Features.Mediator.Commands.ProductDetailCommands;
using KMNVegetable.Application.Features.Mediator.Queries.ProductDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetailList()
        {
            var values = await _mediator.Send(new GetProductDetailQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(int id)
        {
            var values = await _mediator.Send(new GetProductDetailByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailCommand command)
        {
            await _mediator.Send(command);

            return Ok("ProductDetail Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveProductDetail(int id)
        {
            await _mediator.Send(new RemoveProductDetailCommand(id));

            return Ok("ProductDetail Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailCommand command)
        {
            await _mediator.Send(command);

            return Ok("ProductDetail Güncellendi");
        }
    }
}
