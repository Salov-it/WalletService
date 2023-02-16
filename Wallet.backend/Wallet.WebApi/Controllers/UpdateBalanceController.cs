using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wallet.Application.CQRS.command.UpdateBalance;


namespace Wallet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateBalanceController : Controller
    {

         private readonly IMediator mediator;

         public UpdateBalanceController(IMediator mediator)
         {
           this.mediator = mediator;
         }

         // POST api/<UpdateBalance>
         [HttpPost]
         public async void Post(int balance, int id)
         {
           var content = new UpdateBalanceCommand
           {
             balance= balance,
             id = id
           };
           await mediator.Send(content);
         }

        
    }
}
