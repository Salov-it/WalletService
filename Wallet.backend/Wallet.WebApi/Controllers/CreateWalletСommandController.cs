using MediatR;
using Microsoft.AspNetCore.Mvc;
using WalletService.Domain;
using WalletServic.Application;
using WalletService.infrastructure;
using WalletService.Application.CQRS.command.Create;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wallet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateWalletСommandController : ControllerBase
    {
        private readonly IMediator mediator;

        public CreateWalletСommandController(IMediator mediator)
        {
            this.mediator = mediator;
        }
      
        // POST api/<CreateWalletСommand>
        [HttpPost]
        public async void Post(int s)
        {
            var content = new CreateWalletСommand
            {
                OwnerId = s,
            };
        }
    }
}
