
namespace Chapter3
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            BeverageObj = beverage;
        }

        public override string GetDescription()
        {
            return BeverageObj.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return BeverageObj.Cost() + 0.20;
        }
    }
}