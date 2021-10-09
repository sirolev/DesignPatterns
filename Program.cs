using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // set to chapter number you want to run
            int runChapter = 4;

            IChapter[] chapters = {
                new Chapter1(),
                new Chapter2(),
                new Chapter3(),
                new Chapter4()
                };
            
            chapters[runChapter - 1].Run();
        }
    }
}
