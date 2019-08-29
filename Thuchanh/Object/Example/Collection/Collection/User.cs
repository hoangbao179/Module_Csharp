using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class User : IUser
    {
        private int id;
        private string name;
        private string password;
        public List<int?> phoneList = new List<int?>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PassWord { get => password; set => password = value; }
        public string Info()
        {
            if(phoneList == null || phoneList.Count == 0)
            {
                return $"ID:{id}\t Name: {name}\t Password: {password}";
            }
            else
            {
                return $"ID:{id}\t Name: {name}\t Password: {password}\t phoneList: {string.Join(",",phoneList)}";
            }
        }
    }
}
