using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPBlog.Models;

namespace ASPBlog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ASPBlog.Models.ASPBlogContext _context;

        public IndexModel(ASPBlog.Models.ASPBlogContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blog.ToListAsync();
        }
    }
}
