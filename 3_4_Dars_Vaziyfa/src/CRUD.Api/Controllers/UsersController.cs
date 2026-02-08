using CRUD.Api.Dtos;
using CRUD.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers;

[Route("api/admin")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService UserService;
    public UsersController()
    {
        UserService = new UserService();
    }

    [HttpGet ("get - all")]

    public List<UserGetDto>? GetAll(string token)
    {
        return UserService.GetAllUsers(token);
    }

    [HttpGet ("delete")]

    public bool DeleteUser(Guid guid, string token)
    {
        return UserService.DeleteUser(guid, token);
    }

    [HttpDelete ("delete - user - post")]
    public bool DeleteUserPost(Guid guid, string token)
    {
        return UserService.DeleteUserPost(guid, token);
    }

    [HttpPut ("change - role")]

    public bool ChengeRole(Guid guid, string newRole, string token)
    {
        return UserService.ChangeRole(guid, newRole, token); 
    }


}
