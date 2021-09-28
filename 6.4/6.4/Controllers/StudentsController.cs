using _6._4.Models;
using _6._4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6._4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (student.Name == "")
            {
                return ValidationProblem("Nenurodete vardo!");
            }

            if (student.Surname == "")
            {
                return ValidationProblem("Nenurodete pavardes!");
            }

            if (student.DocumentId == "")
            {
                return ValidationProblem("Nenurodete dokumento ID!");
            }

            if (student.Birthday == DateTime.MinValue)
            {
                return ValidationProblem("Nenurodete gimimo datos!");
            }

            var service = new StudentService();

            service.CreateStudent(student);

            return Ok();
              
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var service = new StudentService();

            var students = service.GetStudents();

            return new OkObjectResult(students);
        }
       
        [HttpGet]
        public IActionResult Get(string documentId)
        {
            var service = new StudentService();

            var student = service.GetStudent(documentId);

            return new OkObjectResult(student);
        }
    }
}
