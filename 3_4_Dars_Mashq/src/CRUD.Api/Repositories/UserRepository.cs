using CRUD.Api.Entities;
using System.Text.Json;

namespace CRUD.Api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly string FilePath;
    public UserRepository()
    {
        FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Users.json");
        if (!File.Exists(FilePath))
        {
            var stream = File.Create(FilePath);
            stream.Close();
        }
    }
    public List<User>? GetAllUsers()
    {
        var json = File.ReadAllText(FilePath);
        if(string.IsNullOrEmpty(json))
        {
            return new List<User>;
        }
        var users = JsonSerializer.Deserialize<List<User>>(json);
        return users;
    }

    public void SaveAllUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users);
        File.WriteAllText(FilePath, json);
    }
}
