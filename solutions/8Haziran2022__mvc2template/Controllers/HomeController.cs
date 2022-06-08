using Microsoft.AspNetCore.Mvc;
using mvc1.Models;
using System.Collections.Generic;


namespace mvc1.Controllers;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var postLists = new List<BlogPost>();
            postLists.Add(new BlogPost { Title = "First Post", SubTitle = "This is the first post", DateTime = DateTime.Now });
            postLists.Add(new BlogPost { Title = "Second Post", SubTitle = "This is the second post", DateTime = DateTime.Now });
            postLists.Add(new BlogPost { Title = "Third Post", SubTitle = "This is the third post", DateTime = DateTime.Now });


            return View(postLists);
        }


        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        public string GetName()
        {
            return "Çağatay Yıldız";
        }

     
    }

