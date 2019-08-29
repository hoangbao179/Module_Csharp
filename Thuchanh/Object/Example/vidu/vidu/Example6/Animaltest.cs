using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example6
{
    class Animaltest
    {
        static void Main()
        {
            var chicken = new Chicken();
            Console.WriteLine(chicken.MakeSound());
            Console.WriteLine(chicken.HowToEat());
            var applered = new Apple();
            Console.WriteLine(applered.HowToEat());


            
        }
    }
}
