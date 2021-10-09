
namespace Chapter4
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory = new NYIngredientFactory();

            if (type.Equals("cheese")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            else if (type.Equals("pepperoni")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Pepperoni Pizza";
            }
            else if (type.Equals("clam")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
            }
            else if (type.Equals("veggie")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
            }

            return pizza;
        }
    }


    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory = new ChicagoIngredientFactory();

            if (type.Equals("cheese")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
            }
            else if (type.Equals("pepperoni")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Pepperoni Pizza";
            }
            else if (type.Equals("clam")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Clam Pizza";
            }
            else if (type.Equals("veggie")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
            }

            return pizza;
        }
    }
}