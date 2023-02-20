using MediatR;
using Microsoft.AspNetCore.Mvc;

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

      
       
       

      
    }
}
