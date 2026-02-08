using CRUD.Api.Entities;

namespace CRUD.Api.Repositories;

public interface IPostRepository
{
    public List<Post> GetAllPosts();
    public void SaveAllPosts(List<Post> posts);
}