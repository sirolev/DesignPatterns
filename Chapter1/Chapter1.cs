using System;
using System.Collections.Generic;
using Chapter1;

namespace Code
{
    public class Chapter1 : IChapter
    {
        void IChapter.Run() {
            
            Duck mallardDuck = new MallardDuck();
            Duck rubberDuck = new RubberDuck();
            Duck woodDuck = new WoodDuck();
            
            List<Duck> ducks = new List<Duck>() {mallardDuck, rubberDuck, woodDuck};

            foreach (Duck duck in ducks) {
                Console.WriteLine("-------------");
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
            }
            Console.WriteLine("-------------");
            

            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();
        }
    }
}