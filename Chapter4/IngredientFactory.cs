
namespace Chapter4
{
    public interface IIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggie[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clam CreateClam();
    }
}