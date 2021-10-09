using System;
using Chapter4;

namespace Code
{
    class Chapter4 : IChapter
    {
        void IChapter.Run()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0}\n", pizza.Name);

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a {0}\n", pizza.Name);
        }
    }
}