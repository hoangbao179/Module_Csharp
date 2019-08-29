using System;
using System.Collections.Generic;
using System.Text;
using vidu.Example9.Models;

namespace vidu.Example9
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract void RemovePhone(string name);
        public abstract void SearchPhone(string name);
        public abstract void Sort();


    }
}
