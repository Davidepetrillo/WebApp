using Microsoft.AspNetCore.Mvc;
using NetCore_01.Models;
using NetCore_01.Utils;

namespace NetCore_01.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            List<Post> posts = PostData.GetPosts();

            return View("HomePage", posts);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Post postFound = null;

            foreach (Post post in PostData.GetPosts())
            {
                if (post.Id == id)
                {
                    postFound = post;
                    break;
                }
            }

            if (postFound != null)
            {
                return View("Details", postFound);
            }
            else
            {
                return NotFound("Il post con id " + id + " non è stato trovato");
            }
        }
    }
}