using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOLID.CleanArchitecture_.NET.Application.Identity;
using SOLID.CleanArchitecture_.NET.Application.Model.Identity;

namespace SOLID.CleanArchitecture_.NET.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService auth)
        {
            _authService = auth;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
        {
            return Ok(await _authService.Login(request));
        }
        [HttpPost("register")]
        public async Task<ActionResult<RegisterationResponse>> Register(RegistrationRequest request)
        {
            return Ok(await _authService.Register(request));
        }
    }
}
