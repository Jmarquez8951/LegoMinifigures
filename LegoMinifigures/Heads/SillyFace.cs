using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class SillyFace
    {
        public Faces FaceType { get; set; }
        public string Color { get; set; }
        public int FunnyStrength { get; } = 20;

        public SillyFace (Faces faceType, string color)
        {
            FaceType = faceType;
            Color = color;
            Console.WriteLine("SillyFace instantiated");
        }

        public void GiveTheLook()
        {
            if (FunnyStrength > 20)
            {
                Console.WriteLine("You won the funny face contest.");
            }
            else
            {
                Console.WriteLine("You lost the contest.");
            }
        }

        public void IntimidationCheck()
        {
            if (FunnyStrength < 5)
            {
                Console.WriteLine("Very intimidating");
            }
            else
            {
                Console.WriteLine("Too funny to be intimidating");
            }
        }
    }

    enum Faces
    {
        Googley,
        Crossed,
        Duck
    }
}
