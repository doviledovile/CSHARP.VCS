using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uzduotis_6._3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LastNameController : ControllerBase
    {
        [HttpPost]
        public IActionResult FilterLastName (string [] lastNames)
        {
            var filterLastNames = new List<string>();

            foreach (string lastName in lastNames)
            {
                if (lastName.ToLower().StartsWith ('a'))
                {
                    filterLastNames.Add(lastName);
                }
            }

            return new OkObjectResult(filterLastNames);
        }
    }
}
