using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController

      
        public IActionResult Index()
        {
            ViewBag.Title = "title";
            ViewBag.Date = DateTime.Now;

            var post = new Post
            {
                Title = "new Title",
                Posted = DateTime.Now,
                Author = "haval",
                Body = "this is the body of the post and you can type anything",

            };
            return View(post);
        }

    }
}
