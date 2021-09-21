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
//    public class NamesController : ControllerBase
//    {
//        [HttpGet]
//        public IActionResult getNames(string name)
//        {
//            string[] names = {
//                "Rimgaudas",
//                "Joginte",
//                "Kamile",
//                "Edita",
//                "Eufemija",
//                "Gediminas",
//                "Kornelijus" };

//            string message = "";

//            for (int i = 0; i < names.Length; i++)
//            {
//                if (names[i] == name)

//                {
//                    // TODO LOGIKA KAI RANDU VARDA MASYVE
//                    message = $"Sveikiname su vardo diena,{name}!";
//                    break;
//                }
//                else
//                {
//                    // TODO LOGIKA, KAI NERANDU VARDO MASYVE
//                    var namesInString = string.Join(", ", names);
//                    message = $"Šiandien vardo dieną švenčia: {namesInString}";
//                }
//                return new OkObjectResult(message);
//            }
//        }
//    }
//}
