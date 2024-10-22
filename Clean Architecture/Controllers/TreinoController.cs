using Clean_Architecture.Application.Account;
using Clean_Architecture.Application.DTOs;
using Clean_Architecture.Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;


namespace Clean_Architecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreinoController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAccountPjService _accountPj;
        private readonly string _baseUrl;
        private readonly IAuthService _authService;
        public TreinoController(IAccountPjService accountPj, IConfiguration configuration, IAuthService authService)
        {

            _accountPj = accountPj;
            _baseUrl = configuration["BaseUrl"];
            _authService = authService;
        }


        [HttpPost]
        [Route("CreateAccountPJ")]
        public async Task<IActionResult> CreateAccountPJ( DtoUserId item)
        {
            try
            {
                DtoRetornCreateAccount send = await _accountPj.OpenAccount(item);
                return StatusCode(StatusCodes.Status200OK, send);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



    }
}
