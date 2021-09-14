using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 10");
            var grade = Console.ReadLine();

            switch (grade)    // jeigu "skaicius" yra:
            {
                case "10":   // 10
                    Console.WriteLine("Puikiai");
                    break;
                case "9":
                    Console.WriteLine("Labai gerai");
                    break;
                case "8":  // " rasosi stringai, o jeigu int, konvertuojam, tada be kabuciu rasosi
                    Console.WriteLine("Gerai");
                    break;

                default:     // default reiskia, kad visais kitais atvejais
                    Console.WriteLine("Jus neislaikete, pabandykite dar karta");
                    break;
            }
        }
    }
}
