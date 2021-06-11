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
        public string Index()
        {
            return "blog";
        }

    }
}
