using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class SunglassesFace
    {
        public string GlassesColor { get; set; }
        public bool IsCool { get; private set; } = true;
        public bool IsSuperCool { get; private set; } = false;

        public SunglassesFace(string color)
        {
            GlassesColor = color.ToLower();
            Console.WriteLine("Sunglasses instantiated");
        }

        public void Charisma()
        {
            if (GlassesColor == "black")
            {
                IsSuperCool = true;
            }
            else
            {
                IsCool = false;
            }
        }

        public void HowCool()
        {
            if (IsSuperCool == true && IsCool == true)
            {
                Console.WriteLine("Coolness overload");
            }
            else
            {
                Console.WriteLine("Pretty cool");
            }
        }
    }
}
