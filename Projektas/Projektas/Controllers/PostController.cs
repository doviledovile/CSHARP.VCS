using Microsoft.AspNetCore.Mvc;
using Projektas.Services;
using System;


namespace Projektas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (blog.Login == "")
            {
                return ValidationProblem("Slapyvardis");
            }

            if (blog.PostName == "")
            {
                return ValidationProblem("Teksto pavadinimas");
            }

            if (blog.Date == DateTime.MaxValue)
            {
                return ValidationProblem("Data");
            }

            if (blog.Id == 0)
            {
                return ValidationProblem("Id");
            }

            if (blog.BlogText == "")
            {
                return ValidationProblem("Tekstas");
            }

            var service = new BlogService();

            service.CreateBlog(blog);

            return Ok();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var service = new BlogService();
            var blogs = service.GetBlogs();

            return new OkObjectResult(blogs);
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var service = new BlogService();

            var blog = service.GetBlog(id);

            return new OkObjectResult(blog);
        }
    }
}