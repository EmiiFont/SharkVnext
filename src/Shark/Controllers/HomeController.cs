using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Shark.Persistence.Entities;

namespace Shark.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var post = new Post()
            {
                Content = "Some Content",
                Title = "My First Post",

            };

            var postRepo = new MongoRepository<Post>();
            postRepo.Insert(post);
           
            


            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page...";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }

}