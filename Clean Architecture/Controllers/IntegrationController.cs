
using Clean_Architecture.Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;


namespace Clean_Architecture.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IntegrationController : ControllerBase
    {

        private readonly IConfiguration _config;
        private readonly IAccountPjService _accountPj;
        private readonly string _baseUrl;
        private readonly IAuthService _authService;
        public IntegrationController(IAccountPjService accountPj, IConfiguration configuration, IAuthService authService)
        {
            _accountPj = accountPj;
            _baseUrl = configuration["BaseUrl"];
            _authService = authService;
        }



        [HttpPost("RegisterAndLogin")]
        public async Task<IActionResult> RegisterAndLogin()
        {
            try
            {
                var token = await _authService.RegisterAndLoginAsync();
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
 }



