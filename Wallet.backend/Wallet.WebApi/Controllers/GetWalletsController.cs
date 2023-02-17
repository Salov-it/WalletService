using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wallet.Application.CQRS.Querries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wallet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetWalletsController : ControllerBase
    {
        private readonly IMediator mediator;

        public GetWalletsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<GetWalletsController>
        [HttpGet]
        public async Task<ActionResult<WalletdetailslVn>> Get()
        {
            var query = new GetWalletsQuery
            {
                id = 1
            };
            var vm = await mediator.Send(query);

            return Ok(vm);
        }

      
    }
}
