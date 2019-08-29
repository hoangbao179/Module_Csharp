using System;
using System.Collections;
using vidu.Example9.Models;

namespace vidu.Example9
{
    public class PhoneBook : Phone
    {
        public ArrayList PhoneList = new ArrayList();
        public override void InsertPhone(string name, string phone)
        {
            if (PhoneList != null && UserIsExited(name)) //đôi cái tên vào đây nếu có thì thêm k có thôi
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        if (phoneItem.PhoneNumber != phone)
                        {
                            phoneItem.PhoneNumber += ":" + phone;
                        }
                    }
                }
            }
            else
            {
                //cach1
                var phoneItem = new PhoneItem();
                phoneItem.Name = name;
                phoneItem.PhoneNumber = phone;
                PhoneList.Add(phoneItem);
                //cach2
                //var pI = new PhoneItem()      //giong nhu tren
                //{
                //    Name = name,
                //    PhoneNumber = phone
                //};
                //PhoneList.Add(pI);
                //cach3
                //PhoneList.Add(new PhoneItem()
                //{
                //
                //    Name = name,
                //    PhoneNumber = phone
                //});

            }
        }
        public override void RemovePhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        PhoneList.Remove(phoneItem);


                    }
                }
            }
        }
        public override void UpdatePhone(string name, string newPhone)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        phoneItem.PhoneNumber = newPhone;
                    }
                }
            }
        }
        public override void SearchPhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Phonenumber's {0} is {1}", name, phoneItem.PhoneNumber);
                        break;
                    }
                }
            }
        }

        public override void Sort()
        {
            PhoneList.Sort(new SortPhone());
        }
        public class SortPhone : IComparer
        {
            int IComparer.Compare(Object a, Object b)
            {
                PhoneItem a1 = a as PhoneItem;
                PhoneItem b1 = b as PhoneItem;
                return (string.Compare(a1.Name, b1.Name, false));
            }
        }
        private bool UserIsExited(string userName)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneitem in PhoneList)
                {
                    if (phoneitem.Name == userName)
                        return true;
                }
            }
            return false;
        }
    }
}
