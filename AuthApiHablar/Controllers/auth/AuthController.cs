using AuthApiHablar.Core.Dtos;
using AuthApiHablar.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthApiHablar.Controllers.auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto resgisterDto)
        {
            var registerResult = await _authService.ResgisterAsync(resgisterDto);

            if (registerResult.IsSuccess)
                return Ok(registerResult);

            return BadRequest(registerResult);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var loginResult = await _authService.LoginAsync(loginDto);

            if (loginResult.IsSuccess)
                return Ok(loginResult);
            return BadRequest(loginResult);
        }
    }
}
