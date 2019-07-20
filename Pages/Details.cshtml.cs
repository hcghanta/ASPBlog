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
    public class DetailsModel : PageModel
    {
        private readonly ASPBlog.Models.ASPBlogContext _context;

        public DetailsModel(ASPBlog.Models.ASPBlogContext context)
        {
            _context = context;
        }

        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog = await _context.Blog.FirstOrDefaultAsync(m => m.ID == id);
            Blog.Hits += 1;
            _context.Attach(Blog).State = EntityState.Modified;
            
            await _context.SaveChangesAsync();

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
