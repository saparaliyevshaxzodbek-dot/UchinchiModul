using CRUD.Api.Dtos;
using CRUD.Api.Entities;
using CRUD.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService UserService;

        public UsersController()
        {
            UserService = new UserService();    
        }
        [HttpGet("get-all")]

        public List<UserGetDto>? GetAll(string token)
        {
            return UserService.GetAllUsers(token);
        }

        [HttpDelete("delete")]
        public bool DeleteUsere(Guid guid, string token)
        {
            return UserService.DeleteUser(guid, token);
        }

        [HttpDelete("delete -user-post")]
        public bool DeletePost(Guid guid, string token)
        {
            return UserService.DeleteUserPost(guid, token);
        }

        [HttpPut("change - role")]

        public bool ChangeRole(Guid guid, string newrole, string token)
        {
            return UserService.ChangeRole(guid, newrole, token);
        }
    }
}
