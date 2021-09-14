using System;

namespace HelloWorld       //sia erdve pasivadinau taip ir pagal tai galesiu rasti
{
    class Program    // nereik pervardint sito pav
    {
        static void Main(string[] args)    // metodo (Main) pervardint jau negalim
        {
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();    // galima naudot vietoj string var visur kur string rasiau. jis nustatys koks tipas automatiskai skaitymo metu
            
            Console.WriteLine("Kokia tavo pavarde?");
            string lastName = Console.ReadLine();
           
            Console.WriteLine("Kiek tau metu?");
            string year = Console.ReadLine();
           
            Console.WriteLine(name + " " + lastName + " " + year); 
            // arba rasau Console.WriteeLine(string.Concat(name , surname , age); CIA JAU REIKIA STRING RASYT, NEGALIMA VAR, NES CIA JAU TIPAS METODU
            // arba rasau Console.WriteLine($"{name} {lastName} {year}");
            // arba rasau Console.Write ("{0} {1} {2}", name, surname, age);
            {


            }
        }
    }
}
