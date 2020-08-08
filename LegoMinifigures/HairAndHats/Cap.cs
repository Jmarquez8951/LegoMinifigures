using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LegoMinifigures.HairAndHats
{
    class Cap
    {
        public string Color { get; set; }
        public string Design { get; set; }
        public int Armor;
        

        public Cap(string color, string design)
        {
            Color = color.ToLower();
            Design = design;
            Console.WriteLine("Cap instantiated");
        }

        public void CapStyle()
        {
            if (Design == "cool")
            {
                Console.WriteLine("Very nice cap you got there.");
            }
            else
            {
                Console.WriteLine("It's an ok cap.");
            }
        }

        public void CapArmor()
        {
            if (Color == "red")
            {
                Armor = 15;
            } else
            {
                Armor = 10;
            }
        }
    }
}
