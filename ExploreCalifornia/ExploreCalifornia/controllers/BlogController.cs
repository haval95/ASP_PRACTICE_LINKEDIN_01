using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        // GET: BlogController
        private readonly BlogDataContext _db;
        public BlogController(BlogDataContext db)
        {
            _db = db;
        }
      
        [Route("")]
        public IActionResult Index()
        {
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray(); 
          /*  ViewBag.Title = "title";
            ViewBag.Date = DateTime.Now;

            var post = new Post
            {
                Title = "new Title",
                Posted = DateTime.Now,
                Author = "haval",
                Body = "this is the body of the post and you can type anything",

            };*/
            return View(posts);
        }

        [Route("{year}/{month}/{key}")]
        public IActionResult post(int year, int month, string key)
        {
            var post = _db.Posts.FirstOrDefault(x => x.key == key);
    
            return View(post);
        }


        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Post post)
        {

            //if the submitted input was wrong then send back teh page
            if (!ModelState.IsValid)
            {
                return View();


            }
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;
            _db.Posts.Add(post);
            _db.SaveChanges();
            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.key
            });
        }



    }
}
