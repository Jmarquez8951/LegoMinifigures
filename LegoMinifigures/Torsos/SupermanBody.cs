using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Torsos
{
    class SupermanBody
    {
        public int Health { get; } = 250;
        public bool canRegenerate = true;

        public SupermanBody()
        {
            Console.WriteLine("SupermanBody instantiated");
        }

        public void Hover()
        {
            Console.WriteLine("You can hover now");
        }

        public void LaserVision()
        {
            Console.WriteLine("You now have laser vision.");
        }
    }
}
