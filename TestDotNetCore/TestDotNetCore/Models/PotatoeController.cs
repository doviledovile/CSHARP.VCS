using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDotNetCore.Models
{
    public class PotatoeController
    {
        public double Size;
        public string Softness;
        public double Weight;
        public string Color;
        public string Type;

        public string GetInformation()
        {
            var potatoe = new Potatoe();
            potatoe.Size = 50;
            potatoe.Softness = "minksta";
            potatoe.Weight = 50;
            potatoe.Color = "raudona";
            potatoe.Type = "kaimiskos";

            var potatoe2 = new Potatoe();
            potatoe.Size = 60;
            potatoe.Softness = "kieta";
            potatoe.Weight = 65;
            potatoe.Color = "geltona";
            potatoe.Type = "maksimines";

            PotatoeController[] potatoes = new PotatoeController[] {potatoe};

        return $"Bulves dydis yra {Size}, Bulves minkstumas yra {Softness}, Bulves svoris yra {Weight}, Bulves spalva yra {Color}, Bulves rusis yra {Type}";
        }
    }

    internal class Potatoe
    {
        public Potatoe()
        {
        }

        public string Softness { get; internal set; }
        public int Weight { get; internal set; }
        public string Color { get; internal set; }
        public string Type { get; internal set; }
        public int Size { get; internal set; }
    }
}
