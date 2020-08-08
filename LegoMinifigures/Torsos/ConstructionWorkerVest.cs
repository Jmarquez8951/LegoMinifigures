using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Torsos
{
    class ConstructionWorkerVest
    {
        public bool Visibilty { get; } = true;
        public bool Planning { get; } = true;

        public ConstructionWorkerVest()
        {
            Console.WriteLine("ConstructionWorkerVest instantiated");
        }

        public void canBeSeen()
        {
            if (Visibilty == true)
            {
                Console.WriteLine("People from everywhere can see you at all times");
            }
            else
            {
                Console.WriteLine("You are invisible to the majority of the population");
            }
        }

        public void canPlan()
        {
            if (Planning == true)
            {
                Console.WriteLine("You can plan anything that you set your mind to");
            }
            else
            {
                Console.WriteLine("You can't plan for the life of you");
            }
        }
    }
}
