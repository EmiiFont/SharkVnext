using Microsoft.AspNet.Mvc;
using Shark.Persistence.Entities;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Shark.Api.Controllers
{
    [Route("api/posts/[action]")]
    public class PostController : Controller
    {
        private readonly MongoRepository<Post> _postRepository = new MongoRepository<Post>();

        [HttpGet("~/api/post")]
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
    }
}
