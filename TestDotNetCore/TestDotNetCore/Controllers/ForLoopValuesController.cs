using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDotNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ForLoopValuesController : ControllerBase
    {

        // contral k c uzkomentuoja

        /* [HttpGet]
         public IActionResult FirstExample() 
         {
             string line = "";

             for (int i = 0; i < 10; i++) 
             {
                 if(i % 2 == 0)  // modaline dalyba, kai grazinama liekana
                 {

                 line += i + "\n";    //  \n reiskia, kad is naujos eilutes rasys

                 }
             }
             return new OkObjectResult(line);
         }*/

        [HttpGet]
        public IActionResult SecondExample() { 
            string result = "";
            //int i = 0;
            //while (i < 20)
            //{
            //    result += i + ", ";    // kad nepridetu paskutinio kablelio padarem
            //    i += 3;
            //}    

            for (int i = 0; i < 20; i += 3)
            {

                if (i % 3 == 0)
                {
                    result += i + ", ";
                }
            }
            return new OkObjectResult(result);
        }
    }
}
