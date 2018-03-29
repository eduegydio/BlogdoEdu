using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogdoEdu.Models
{
    public class BlogContext: DbContext
    
    {
        public DbSet<Post> Posts { get; set; }

        public BlogContext() : base("DefaultConnection")
        {

        }

    }
}