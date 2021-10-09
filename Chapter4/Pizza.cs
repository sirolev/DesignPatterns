using System;
using System.Collections.Generic;

namespace Chapter4
{
    public abstract class Pizza
    {
        public string Name;

        protected Dough dough;
        protected Sauce sauce;
        protected Cheese cheese;
        protected Veggie[] veggies;
        protected Pepperoni pepperoni;
        protected Clam clam;

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}