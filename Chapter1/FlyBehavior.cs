using System;

namespace Chapter1
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        void IFlyBehavior.Fly() =>
            Console.WriteLine("Im Flying!");
    }

    public class FlyNoWay : IFlyBehavior
    {
        void IFlyBehavior.Fly() =>
            Console.WriteLine("I cant fly..");
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        void IFlyBehavior.Fly() =>
            Console.WriteLine("Im flying with a rocket!");
    }
}