using CRUD.Api.Dtos;
using CRUD.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService PostService;

        public PostsController()
        {
            PostService = new PostService();
        }

        [HttpPost ("add")]
        public Guid Create(PostCreateDto postCreateDto , string token)
        {
            return PostService.AddPost(postCreateDto, token);
        }

        [HttpGet ("get - all")]

        public List<PostGetDto> GetAll(string token)
        {
            return PostService.GetAllPosts(token);
        }

        [HttpGet ("get - all - by - admin")]

        public List<PostGetDto> GetAllPostByAdmin(string token)
        {
            return PostService.GetAllPostsByAdmin(token);
        }

        [HttpDelete ("delete")]
        public bool Ddelete(Guid id, string token )
        {
            return PostService.DeletePost(id, token);
        }

        [HttpPut ("update")]

        public bool Update(Guid guid, string token, PostCreateDto postCreateDto)
        {
                return PostService.UpdatePost(guid, postCreateDto, token);
        }
    }
}
