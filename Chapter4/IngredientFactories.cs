
namespace Chapter4
{
    public class NYIngredientFactory : IIngredientFactory
    {
        Dough IIngredientFactory.CreateDough() { return new ThinCrustDough(); }
        Sauce IIngredientFactory.CreateSauce() { return new MarinaraSauce(); }
        Cheese IIngredientFactory.CreateCheese() { return new ReggianoCheese(); }
        Pepperoni IIngredientFactory.CreatePepperoni() { return new SlicedPepperoni(); }
        Clam IIngredientFactory.CreateClam() { return new FreshClams(); }
        Veggie[] IIngredientFactory.CreateVeggies()
        {
            Veggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }


    public class ChicagoIngredientFactory : IIngredientFactory
    {
        Dough IIngredientFactory.CreateDough() { return new ThichCrustDough(); }
        Sauce IIngredientFactory.CreateSauce() { return new PlumTomatoSauce(); }
        Cheese IIngredientFactory.CreateCheese() { return new MozzarellaCheese(); }
        Pepperoni IIngredientFactory.CreatePepperoni() { return new SlicedPepperoni(); }
        Clam IIngredientFactory.CreateClam() { return new FrozenClams(); }
        Veggie[] IIngredientFactory.CreateVeggies()
        {
            Veggie[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}