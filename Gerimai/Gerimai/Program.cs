using System;

namespace Gerimai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite norima gerima");
            var drinks = Console.ReadLine();
            var options = "";
            switch (drinks)
            {
                case "1":
                    options = "limonadas";
                    break;
                case "2":
                    options = "arbata";
                    break;
                case "3":
                    options = "kakava";
                    break;
                case "4":
                    options = "kava";
                    break;
                case "5":
                    options = "nieko";
                    break;
               
                default:

                    if(options != "")
                    {
                        Console.WriteLine ("Jus pasirinkote: " + options);
                        {

                        }
                    }   
                   

            }


        }
    }
}



// su switch