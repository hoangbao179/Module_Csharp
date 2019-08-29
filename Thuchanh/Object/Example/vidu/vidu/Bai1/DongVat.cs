using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Bai1
{
    public abstract class DongVat
    {
        private string name;
        private string coat;
        private int leg;

        public string Name { get => name; set => name = value; }
        public string Coat { get => coat; set => coat = value; }
        public int Leg { get => leg; set => leg = value; }
        public DongVat()
        {

        }
        public DongVat(string Name, string Coat, int Leg)
        {
            name = Name;
            coat = Coat;
            leg = Leg;
        }
        public abstract string BietBay();

    }
}
