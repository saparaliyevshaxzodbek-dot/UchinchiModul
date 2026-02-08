using CRUD.Api.Dtos;
using CRUD.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService PostService;
        public PostsController()
        {
            PostService = new PostService();
        }

        [HttpPost("create")]
        public Guid Create(PostCreateDto postCreateDto)
        {
            var postId = PostService.CreatePost(postCreateDto);
            return postId;
        }

        [HttpGet("get-all")]
        public List<PostGetDto> GetAll()
        {
            return PostService.GetAllPosts();
        }

        [HttpGet("get-by-id")]
        public PostGetDto? GetById(Guid postId)
        {
            return PostService.GetPostById(postId);
        }

        [HttpDelete("delete")]
        public bool Delete(Guid postId)
        {
            return PostService.DeletePost(postId);
        }

        [HttpPut]
        public bool Update(Guid postId, PostUpdateDto postUpdateDto)
        {
            return PostService.UpdatePost(postId, postUpdateDto);
        }
    }
    }
