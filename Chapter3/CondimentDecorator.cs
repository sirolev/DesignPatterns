
namespace Chapter3
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage BeverageObj { get; protected set; }

        public abstract override string GetDescription();
    }
}