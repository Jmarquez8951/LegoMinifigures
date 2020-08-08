using LegoMinifigures.HairAndHats;
using LegoMinifigures.Heads;
using LegoMinifigures.Legs;
using LegoMinifigures.Torsos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main()
        {
            var MyHair = new Mohawk(MainColor.Red, 4);
            MyHair.StrengthByLength();
            var MyCap = new Cap("Red", "cool");
            MyCap.CapArmor();
            MyCap.CapStyle();
            var MyFace = new SillyFace(Faces.Googley, "blue");
            MyFace.IntimidationCheck();
            MyFace.GiveTheLook();
            var newLegs = new KidStumps();
            newLegs.CanRun();
            newLegs.HowFast();
            var Glasses = new SunglassesFace("black");
            Glasses.Charisma();
            Glasses.HowCool();
            var pants = new CoolPants("red");
            pants.PowerSelector();
            pants.superPowers();
            var body = new SupermanBody();
            body.Hover();
            body.LaserVision();
            var vest = new ConstructionWorkerVest();
            vest.canPlan();
            vest.canBeSeen();
        }
    }
}
