using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.HairAndHats
{
    class Mohawk
    {
        public MainColor Color { get; set; }
        public int Length { get; set; }

        public Mohawk(MainColor color, int length)
        {
            Color = color;
            Length = length;
            Console.WriteLine("Mohawk instantiated");
            PowerByColor();
        }
        public void PowerByColor()
        {
            if (Color == MainColor.Black)
            {
                Console.WriteLine("Power of the Underworld");
            } else if (Color == MainColor.Blue) {
                Console.WriteLine("Power of the Sea");
            } else if (Color == MainColor.Green)
            {
                Console.WriteLine("Power of Nature");
            } else if (Color == MainColor.Pink)
            {
                Console.WriteLine("Power of Love");
            } else if (Color == MainColor.Red)
            {
                Console.WriteLine("Power of Fire");
            } else if (Color == MainColor.Yellow)
            {
                Console.WriteLine("Power of Lightning");
            } else
            {
                Console.WriteLine("Your hair has no powers");
            }
        }

        public void StrengthByLength()
        {
            if (Length > 10)
            {
                Console.WriteLine("You have infinite power");
            } else
            {
                Console.WriteLine("You can only use your powers 4 times a day");
            }
        }
    }

    enum MainColor
    {
        Yellow,
        Red,
        Blue,
        Black,
        Green,
        Pink
    }
}
