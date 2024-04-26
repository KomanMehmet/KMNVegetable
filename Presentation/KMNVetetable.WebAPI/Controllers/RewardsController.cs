using KMNVegetable.Application.Features.Mediator.Commands.RewardCommands;
using KMNVegetable.Application.Features.Mediator.Queries.RewardQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMNVetetable.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RewardsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> RewardList()
        {
            var values = await _mediator.Send(new GetRewardQuery());

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRewardById(int id)
        {
            var values = await _mediator.Send(new GetRewardByIdQuery(id));

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReward(CreateRewardCommand command)
        {
            await _mediator.Send(command);

            return Ok("Reward Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveReward(int id)
        {
            await _mediator.Send(new RemoveRewardCommand(id));

            return Ok("Reward Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReward(UpdateRewardCommand command)
        {
            await _mediator.Send(command);

            return Ok("Reward Güncellendi");
        }
    }
}
