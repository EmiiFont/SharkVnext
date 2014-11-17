using Microsoft.AspNet.Mvc;
using Shark.Persistence.Entities;
using Shark.Persistence.Repositories;
using System.Collections.Generic;


namespace Shark.Api.Controllers
{
    [Route("api/posts/[action]")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet("~/api/posts")]
        public IEnumerable<Post> Get()
        {
            return _postRepository.GetAll();
        }

        [HttpPost("~/api/posts")]
        public Post Save(Post newPost)
        {
            _postRepository.Insert(newPost);
            return newPost;
        }
        [HttpDelete("~/api/posts")]
        public bool Delete(string id)
        {
            //TODO: delete post but move it to other database to keep history of things
            return false;
        }
    }
}
