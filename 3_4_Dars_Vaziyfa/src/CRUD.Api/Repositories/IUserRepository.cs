using CRUD.Api.Entities;

namespace CRUD.Api.Repositories;

public interface IUserRepository
{
    public List<User>? GetAllUsers();
    public void SaveAllUsers(List<User> users);
}