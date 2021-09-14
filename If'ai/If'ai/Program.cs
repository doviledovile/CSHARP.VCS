using System;

namespace If_ai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite amžių: ");
            var age = Convert.ToInt32(Console.ReadLine());  // vietoj var galima statyt int

            if (age >= 20 && age < 50)
            {
                Console.WriteLine("Sveiki prisijungę!");
            }
            else if (age >= 50 && age <= 70)
            {
                Console.WriteLine("Jums priklauso specialus pasiūlymas!");
            }
            else
            {
                Console.WriteLine("Alkoholio nibudiet");
            }
         }
    }
}





// patikrint ar pvz vietoj skaiciaus ivedant spindulio plota, neiveda raides. 
// tada naudoji if'us