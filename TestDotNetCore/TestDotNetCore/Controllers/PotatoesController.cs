using Microsoft.AspNetCore.Mvc;



namespace FarmerService.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class PotatoesController : ControllerBase
    {
        private int counter;

        /// <summary>
        /// Suskaičiuoja kiek iš viso buvo parduota, vidurkį 
        /// ir kiek ūkininkų kurie pardavė daugiau nei 50 kilogramų
        /// </summary>
        /// <param name="potatoes"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CalculateResults(int[] potatoes)
        {
            string message = "";


            // sum skaiciavimas
            int sum = 0;
            for (int i = 0; i < potatoes.Length; i++)
            {
                // sum += potatoes[i]; // sita sutrumpinu -->
                _ = CalculateSum(potatoes);
            }
            message += "Iš viso bulvių buvo parduota " + sum + " kg.";


            // vidurkio skaiciavimas
            var average = CalculateAverage(sum, potatoes.Length);  // sita galima ir i metoda irasyt, nes lengviau butu aisku ka daro (sitas metod skaiciuja suma, kitas vidurki ir pan(
            message += $"Vieno ūkininko parduotų bulvių vidurkis kilogramais yra {average} kg.";


            // suskaiciuoti tuos kurie pardave daugiau nei 50 kg bulviu
            int counter = CalculateFarmersWhoSoldMoreThenFiftyKilograms(potatoes);


            
            message += $"Ūkininkų, kurie pardavė daugiau negu 50 kilogramų yra {counter}";


            return new OkObjectResult(message);
        }

        private int CalculateSum (int [] collection)    
            // Calculate sum yra metodas, ji visada vadinam taip, ka jis darys
            // () rašome ka jis kvies, masyva siuo atveju
            // collection siaip pasirinkimas, galima vadinti ir kitaip. Universaliau, nei bulves, tai del to irasem
        {
            // mes db norim sutrumpinti
            int sum = 0;
            for (int i = 0; i < collection.Length; i++)
            {

                sum += collection[i];
            }

            return sum;
            // return sum (sumą), nes ka suskaiciuosiu, ta ir grazinsiu
            }
        private double CalculateAverage(int sum, int count)
        {
            return sum / count;
        }
        private int CalculateFarmersWhoSoldMoreThenFiftyKilograms(int[] potatoes)
        {
            for (int i = 0; i < potatoes.Length; i++)
            {
                if (potatoes[i] > 50)
                {
                    return counter++;
                }
            }
            return counter;
        }
        }
    }
