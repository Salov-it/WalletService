using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletService.Application.CQRS.Command.Create;
using WalletService.Application.CQRS.Querries.GetByOwnerQuerry;

namespace WalletService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IMediator mediator;

        public WalletController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromHeader] int ownerId)
        {
            var content = new CreateWalletСommand
            {
                OwnerId = ownerId,
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet]
        public async Task<IActionResult> GetByOwner([FromQuery] int ownerId)
        {
            var content = new GetByOwnerQuerry
            {
                OwnerId = ownerId,
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }
}
