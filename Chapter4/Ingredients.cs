
namespace Chapter4
{
    public abstract class Dough {}
    public abstract class Sauce {}
    public abstract class Cheese {}
    public abstract class Veggie {}
    public abstract class Pepperoni {}
    public abstract class Clam {}


    // Dough
    public class ThinCrustDough : Dough {}
    public class ThichCrustDough : Dough {}
    public class VeryThinCrustDough : Dough {}


    // Sauce
    public class MarinaraSauce : Sauce {}
    public class PlumTomatoSauce : Sauce {}
    public class BruschettaSauce : Sauce {}
    

    // Chese
    public class ReggianoCheese : Cheese {}
    public class MozzarellaCheese : Cheese {}
    public class GoatCheese : Cheese {}


    // Veggies
    public class Garlic : Veggie {}
    public class Onion : Veggie {}
    public class Mushroom : Veggie {}
    public class RedPepper : Veggie {}
    public class BlackOlives : Veggie {}
    public class Spinach : Veggie {}
    public class EggPlant : Veggie {}
    

    // Pepperoni
    public class SlicedPepperoni : Pepperoni {}


    // Clams
    public class FreshClams : Clam {}
    public class FrozenClams : Clam {}
}