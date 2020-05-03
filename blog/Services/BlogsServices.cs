using blog.Data;
using blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Services
{
    public class BlogsServices: IBlogsServices
    {
        private readonly ApplicationDbContext _context;
        public BlogsServices(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/Blogs
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs()
        //{
        //    return await _context.Blogs.ToListAsync();
        //}

        // GET: api/Blogs/5
        //[HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlog(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null)
            {
                // return NotFound();
            }

            return blog;
        }

        //[HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs()
        {
            return await _context.Blogs.ToListAsync();
            //throw new NotImplementedException();
        }
    }
}