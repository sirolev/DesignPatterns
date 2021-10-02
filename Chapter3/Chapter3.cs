using System;
using Chapter3;

namespace Code
{
    public class Chapter3 : IChapter
    {
        void IChapter.Run() {
            Beverage bev1 = new Espresso();
            Console.WriteLine("{0} ${1}", bev1.GetDescription(), bev1.Cost());
            bev1.SetSize(Beverage.Size.VENTI);
            bev1 = new Milk(bev1);
            Console.WriteLine("{0} ${1}", bev1.GetDescription(), bev1.Cost());

            Beverage bev2 = new DarkRoast();
            bev2 = new Mocha(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Whip(bev2);
            Console.WriteLine("{0} ${1}", bev2.GetDescription(), bev2.Cost());

            Beverage bev3 = new HouseBlend();
            bev3 = new Soy(bev3);
            bev3 = new Mocha(bev3);
            bev3 = new Whip(bev3);
            Console.WriteLine("{0} ${1}", bev3.GetDescription(), bev3.Cost());
        }
    }
}