using CRUD.Api.Dtos;
using CRUD.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService AuthService;


        public AuthController()
        {
            AuthService = new AuthService();
        }

        [HttpPost ("registr")]
        public Guid Register(UserRegisterDto userRegisterDto)
        {
            return AuthService.RegisterUser(userRegisterDto);

        }

        [HttpPost("login")]
        public string Login(UserLoginDto userLoginDto)
        {
            return AuthService.LoginUser(userLoginDto);
        }

    }
}
