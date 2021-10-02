
namespace Chapter3
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            BeverageObj = beverage;
        }

        public override string GetDescription()
        {
            return BeverageObj.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return BeverageObj.Cost() + 0.10;
        }
    }
}