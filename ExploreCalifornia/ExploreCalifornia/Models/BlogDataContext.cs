﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class BlogDataContext: DbContext
    {
        public BlogDataContext(DbContextOptions<BlogDataContext> options): base(options)         
        {
            //make suere db exists 
            Database.EnsureCreated();
        }
        public DbSet<Post> Posts { get; set; }
    }
}
