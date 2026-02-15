using CRM.Api.Models;

namespace CRM.Api.Data;

public interface IUserData
{
    public List<User>? GetAllUsers();
    public void SaveAllUsers(List<User> users);
    public bool UserExists(Guid userId);
}