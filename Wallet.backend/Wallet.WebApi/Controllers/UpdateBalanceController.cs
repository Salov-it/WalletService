using MediatR;
using Microsoft.AspNetCore.Mvc;


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

        

        
    }
}
