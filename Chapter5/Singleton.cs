using System;

namespace Chapter5
{
    class Singleton
    {
        private static Singleton instance = null;

        private Singleton() {}
        
        public static Singleton GetInstance(string name)
        {
            if (instance == null)
                instance = new Singleton();
            
            return instance;
        }
    }
}