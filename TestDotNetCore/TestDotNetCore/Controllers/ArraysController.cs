using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace TestDotNetCore.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ArraysController : ControllerBase
//    {

        //[HttpGet]
        //public IActionResult TryArrays()
        //{
            
            // string[] names1 = { "Jonas", "Onute", "Petras" }; // rasai taip, arba -->

            // string[] names2 = new string[3];
            // names2[0] = "Jonas";
            // names2[1] = "Onute";
            // names2[2] = "Petras";

        //    int[] ages = new int[5];
        //    ages[0] = 45;
        //    ages[1] = 36;
        //    ages[3] = 18;
        //    ages[4] = 20;

        //    var sum = ages[0] + ages[2] + ages[3] + ages[4];
        //    double average = (double)sum / ages.Length;

        //    return new OkObjectResult(average);
        //}

//        [HttpPost]
//        public IActionResult CalculateAverage(int[] ages)
//        {
//            double sum = 0;
//            for (int i = 0; i < ages.Length; i++)
//            {

//            }
//            sum += ages[i];
//        }

//        double average = ConsumesAttribute / ages.Length;
//        return new OkObjectResult(average);
    
//        }
//    }
//}
