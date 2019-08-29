using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example6
{
    public class Chicken : Animal, IEdible
    {
        /*public override string MakeSound()
        {
            return " cap cap ";
        }*/
        public override string MakeSound()
        {
            return "pap pap";
        }
        public string HowToEat()
        {
            return "chicken eat rice";
        }
    }
}
