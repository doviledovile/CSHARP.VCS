// Parašykite if sąlyga, kuri patikrintų ar antrasis skaičius yra didesnis už pirmąjį.
// Tiesos atveju turi išvesti, kad antrasis skaičius buvo didesnis už pirmąjį ir
// išvestų antrojo skaičiaus reikšmę.

using System;

namespace If_uzduotis_is_skaidres1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;
            // tikriname ar antrasis sk didesnis uz pirma sk
            if (secondNumber > firstNumber)
            {
                Console.WriteLine($"Antrasis skaičius yra didesnis už pirmąjį. Antrojo skaičiaus reikšmė yra {secondNumber}");
            }
        }
    }
}
