﻿using System;
using System.Globalization;

namespace Homework1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įvesk apskritimo spindulį:");
            string radiusInString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusInString, CultureInfo.InvariantCulture);

            double c = 2 * Math.PI * radius;    // ilgis

            double s = Math.PI * radius * radius;  // plotas

            Console.WriteLine($"Apskrititimo ilgis yra: {c}");
            Console.WriteLine($"Apskritimo plotas yra: {s}");

        }
    }
}
