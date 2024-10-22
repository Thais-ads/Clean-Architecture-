using Clean_Architecture.Application.Account;
using Clean_Architecture.Application.DTOs;
using Clean_Architecture.Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clean_Architecture.Controllers
{
    
    [Route("Treino/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAccountPjService _accountPj;


        public WeatherForecastController(IAccountPjService accountPj)
        {
            _accountPj = accountPj;
        }
        

        [HttpPost]
        [Route("CreateAccountPJ")]
        public async Task<IActionResult> CreateAccountPJ( DtoUserId item)
        {

            DtoRetornCreateAccount send = await _accountPj.OpenAccount(item);

            return StatusCode(StatusCodes.Status200OK, send);

        }
    }
}
