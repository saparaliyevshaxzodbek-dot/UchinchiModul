using CRM.Api.Dtos;
using CRM.Api.Models;

namespace CRM.Api.Services;

public interface IUserService
{
    public Guid AddUser(UserCreateDto userCreateDto);
    public bool DeleteUser(Guid userId);
    public UserGetDto GetUserById(Guid userId);
    public List<UserGetDto> GetAllUsers();
    public bool UpdateUser(Guid guid, UserUpdateDto userUpdateDto);
    void AddUser(User newUser);
}