using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legs
{
    class KidStumps
    {
        public WalkingStyle WalkStyle { get; set; }
        public int Speed { get; }

        public KidStumps()
        {
            WalkStyle = WalkingStyle.Waddle;
            Speed = 5;
            Console.WriteLine("KidStumps instantiated");
        }

        public void CanRun()
        {
            if (WalkStyle == WalkingStyle.Waddle || WalkStyle == WalkingStyle.Crawl)
            {
                Console.WriteLine("Cannot run for you're a penguin.");
            }
            else
            {
                Console.WriteLine("You can run if you believe you can.");
            }
        }

        public void HowFast()
        {
            if (Speed >= 10)
            {
                Console.WriteLine("Slow down there Usain Bolt");
            }
            else if (Speed < 10 && Speed > 6)
            {
                Console.WriteLine("Thats normal speed.");
            }
            else
            {
                Console.WriteLine("You slow");
            }
        }
    }

    enum WalkingStyle
    {
        Waddle,
        Swaggy,
        March,
        Crawl
    }
}
