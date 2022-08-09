using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Contentment
{
    class Address
    {
        public int pincode;
        public string city;

        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void ShowAddress()
        {
            Console.WriteLine();
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;

        Person(int id,string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void Displayperson()
        {
            Console.WriteLine(id+ ""+name);
            adr.ShowAddress();
        }
        static void main(string[]args)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        {
            Address a = new Address(41314,"Indapur");
            Person p;
            p = new Person(1, "Akshay", a);
            p.Displayperson();
        }
    }
}
