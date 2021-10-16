using System;
using Chapter5;

namespace Code
{
    
    class Chapter5 : IChapter
    {
        void IChapter.Run()
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            if (boiler1 == boiler2)
                Console.WriteLine("boiler1 == boiler2");

        }
    }
}