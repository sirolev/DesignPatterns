using System;

namespace Chapter1
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack() =>
            Console.WriteLine("Quack");
    }

    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack() =>
            Console.WriteLine("Squeak");
    }

    public class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack() =>
            Console.WriteLine("<< Silence >>");
    }
}