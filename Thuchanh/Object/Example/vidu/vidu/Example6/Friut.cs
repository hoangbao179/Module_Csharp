using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example6
{
    public abstract class Friut : IEdible
    {
        public abstract string HowToEat();

        public void ngu()
        {
            Console.WriteLine("dep trai");
        }
    }
}
