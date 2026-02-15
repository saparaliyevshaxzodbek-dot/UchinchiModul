using CRUD.Api.Dtos;
using CRUD.Api.Entities;
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

        [HttpPost("add")]
        public Guid Create(PostCreateDto postCreateDto, string token)
        {
            return PostService.AddPost(postCreateDto, token);
        }

        [HttpGet("get-by-Id")]
        public PostGetDto? GetById(Guid id)
        {
            return PostService.GetPostById(id); 
        }

        [HttpDelete("delete")]
        public bool Delete(Guid id, string token)
        {
            return PostService.DeletePost(id, token);
        }

        [HttpPut("update")]
        public bool Update(Guid postId, PostCreateDto postCreateDto, string token)
        {
            return PostService.UpdatePost(postId, postCreateDto, token);
        }



    }
}
