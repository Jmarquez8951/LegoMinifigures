using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LegoMinifigures.Legs
{
    class CoolPants
    {
        public string PantsColor { get; set; }
        public Powers SuperPower { get; set; }

        public CoolPants(string color)
        {
            PantsColor = color;
            Console.WriteLine("CoolPants instantiated");
        }

        public void PowerSelector()
        {
            var rnd = new Random();
            var power = rnd.Next(4);
            switch (power)
            {
                case 1:
                    SuperPower = Powers.Strength;
                    break;
                case 2:
                    SuperPower = Powers.Invisibility;
                    break;
                case 3:
                    SuperPower = Powers.Superspeed;
                    break;
                case 4:
                    SuperPower = Powers.Flying;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Your pants gave you the ability of {SuperPower}");
        }

        public void superPowers()
        {
            if (PantsColor == "red")
            {
                Console.WriteLine("You can use the power for as long as you want");
            }
            else
            {
                Console.WriteLine("You can only use this power 5 times a day");
            }
        }
    }
    enum Powers
    {
        Strength = 1,
        Invisibility,
        Superspeed,
        Flying
    }
}
