using System;

namespace Chapter1
{
    public abstract class Duck {

        public string Name;
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;
        
        public void PerformFly() =>
            FlyBehavior.Fly();

        public void PerformQuack() =>
            QuackBehavior.Quack();
        
        public void SetFlyBehavior(IFlyBehavior fb) =>
            FlyBehavior = fb;
        
        public void SetQuackBehavior(IQuackBehavior qb) =>
            QuackBehavior = qb;
        
        public void Display() =>
            Console.WriteLine("I'm a " + Name);
        
        public void Swim() =>
            Console.WriteLine("I'm swimming");
    }

    public class MallardDuck : Duck {

        public MallardDuck()
        {
            Name = "Mallard Duck";
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }
    }

    public class RubberDuck : Duck {

        public RubberDuck()
        {
            Name = "Rubber Duck";
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
    }

    public class WoodDuck : Duck {

        public WoodDuck()
        {
            Name = "Wood Duck";
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }
    }

    public class ModelDuck : Duck {

        public ModelDuck()
        {
            Name = "Model Duck";
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
    }
}