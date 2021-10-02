
namespace Chapter3
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            BeverageObj = beverage;
        }

        public override string GetDescription()
        {
            return BeverageObj.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return BeverageObj.Cost() + 0.15;
        }
    }
}