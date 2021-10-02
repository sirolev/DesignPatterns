
namespace Chapter3
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            BeverageObj = beverage;
            SetSize(BeverageObj.GetSize());
        }

        public override string GetDescription()
        {
            return BeverageObj.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            double cost = BeverageObj.Cost();

            if (GetSize() == Size.GRANDE)
                cost += 0.10;
            else if (GetSize() == Size.TALL)
                cost += 0.13;
            else if (GetSize() == Size.VENTI)
                cost += 0.16;
            
            return cost;
        }
    }
}