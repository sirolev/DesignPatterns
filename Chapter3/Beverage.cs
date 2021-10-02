using System;

namespace Chapter3
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        Size _size = Size.TALL;

        protected string Description = "Unknown Beverage";

        public virtual string GetDescription() {
            string sizeName = "";
            if (_size == Size.GRANDE)
                sizeName = "Grande";
            else if (_size == Size.TALL)
                sizeName= "Tall";
            else if (_size == Size.VENTI)
                sizeName= "Venti";
            
            return sizeName + " " + Description;
        }

        public void SetSize(Size size) =>
            _size = size;
        
        public Size GetSize() =>
            _size;

        public abstract double Cost();
    }
}