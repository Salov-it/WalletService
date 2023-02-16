using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wallet.Application.CQRS.command;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Net.NetworkInformation;

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
        public async void Post( int Onwerid)
        {
            var content = new CreateWalletСommand
            {
                OwnerId = Onwerid
            };
            await mediator.Send(content);
        }
    }
}
