using BiblioTecApi.DTOs;
using BiblioTecApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioTecApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService auth;

        public AuthController(AuthService auth)
        {
            this.auth = auth;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDto dto)
        {
            try
            {
                var res = auth.Login(dto);
                return Ok();
            }
            catch (Exception ex)
            {

                return Unauthorized(ex.Message);
            }
        }
    }
}
