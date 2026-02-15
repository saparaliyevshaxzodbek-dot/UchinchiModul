using CRUD.Api.Entities;
using System.Text.Json;

namespace CRUD.Api.Repositories;

public class PostRepository : IPostRepository
{
    private readonly string FilePath;
    public PostRepository()
    {
        FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Posts.json");
        if (!File.Exists(FilePath))
        {
            var stream = File.Create(FilePath);
            stream.Close();
        }
    }

    public List<Post>? GetAllPosts()
    {
        var json = File.ReadAllText(FilePath);
        if(string.IsNullOrEmpty(json))
        {
            return new List<Post>();
        }
        var posts = JsonSerializer.Deserialize<List<Post>>(json);
        return posts;
    }

    public void SaveAllPosts(List<Post> posts)
    {
        var json = JsonSerializer.Serialize(posts);
        File.WriteAllText(FilePath, json);
    }
}
