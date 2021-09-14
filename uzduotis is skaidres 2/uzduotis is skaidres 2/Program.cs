// Sukurti šias sudėtingas if sąlygas:
// ar pirmas skaičius didesnis už antrą skaičių ir yra mažesnis už 100;
// ar antras skaičius yra didesnis už 0 ir didesnis už pirmąjį skaičių;
// ar pirmas skaičius yra didesnis už antrąjį ir didesnis už trečiąjį skaičių arba
// teigiamas (didesnis už 0);
// ar trečias skaičius patenka į rėžius [5-10] (>= ir <=) arba yra didesnis už pirmąjį
// skaičių arba yra didesnis už antrąjį skaičių;


using System;

namespace uzduotis_is_skaidres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių");
            var firstNumber = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite trečią skaičių");
            var thirdNumber = Convert.ToDouble(Console.ReadLine());

            if(firstNumber > secondNumber && firstNumber < 100)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrą skaičių ir pirmas skaičius yra mažesnis už 100");
            if (secondNumber > 0 && secondNumber > firstNumber)
                {
                    Console.WriteLine("Antras skaičius yra didesnis už 0 ir antras skaičius yra didesnis už pirmą skaičių");

                    if (firstNumber > secondNumber && firstNumber > thirdNumber || firstNumber > 0)
                    {
                        Console.WriteLine("Primas skaičius yra didesnis už antrąjį ir didesnis už trečiąjį arba teigiamas");
                    }

                    if (thirdNumber >= 5 && thirdNumber <= 10 || thirdNumber > firstNumber || thirdNumber > secondNumber)
                    {
                        Console.WriteLine("trečias skaičius patenka į rėžius [5-10] (>= ir <=) ir yra didesnis už pirmąjį skaičių ir yra didesnis už antrąjį skaičių");
                    }
                }

            }


        }
    }
}
