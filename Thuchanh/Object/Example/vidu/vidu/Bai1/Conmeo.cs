using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Bai1
{
    public class ConMeo : DongVat
    {
        private string eye;
        private string boss;

        public string Boss { get => boss; set => boss = value; }
        public string Eye { get => eye; set => eye = value; }
        public override string BietBay()
        {
            return "meo khong biet bay";
        }
        public ConMeo(string name, string coat, int leg, string eye, string boss) :base(name, coat, leg)
        {
            eye = Eye;
            boss = Boss;
        }
        public ConMeo()
        {

        }
        public void Xuat()
        {
            Console.WriteLine("Meo {0} cua {1} co long mau {2}", Name, Boss, Coat);
        }
    }
}
