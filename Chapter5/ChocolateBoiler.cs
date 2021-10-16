
namespace Chapter5
{
    public class ChocolateBoiler
    {
        public bool Empty {get; private set; }
        public bool Boiled {get; private set; }
        private static ChocolateBoiler uniqueInstance = null;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new ChocolateBoiler();

            return uniqueInstance;
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                // fill the boilder with milk/chocolate mixutre
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
                Empty = true; // drain the boiled milk and chocolate
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
                Boiled = true;
        }
    }
}