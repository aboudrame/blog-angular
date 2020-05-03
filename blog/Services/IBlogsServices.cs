using blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Services
{
    public interface IBlogsServices
    {
        Task<ActionResult<IEnumerable<Blog>>> GetBlogs();
    }
}
