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
        // GET: api/<CreateWalletСommandController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CreateWalletСommandController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CreateWalletСommandController>
        [HttpPost]
        public async void Post( int s)
        {
            var d = new CreateWalletСommand
            {
                OwnerId = s
            };
            await mediator.Send(d);


        }


        // PUT api/<CreateWalletСommandController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CreateWalletСommandController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
