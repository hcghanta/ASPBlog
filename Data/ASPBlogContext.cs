using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPBlog.Models
{
    public class ASPBlogContext : DbContext
    {
        public ASPBlogContext (DbContextOptions<ASPBlogContext> options)
            : base(options)
        {
        }

        public DbSet<ASPBlog.Models.Blog> Blog { get; set; }
    }
}
