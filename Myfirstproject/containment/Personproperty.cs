using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.containment
{
    class Address
    {
        int pincode;
        string city;

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return City; }
            set { city = value; }
        }
    }
    class Personproperty
    {
        int id;
        string name;
        Address adr;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address Adr
        {
            get { return adr; }
            set { adr = value; }
        }
    }
    class PersonInfo
    {
        static void Main(string[] args)
        {
            Personproperty a = new Personproperty();
            a.Id = 12345;
            a.Name = "Vishal";
            a.Adr = new Address();
            a.Adr.Pincode = 41314;
            a.Adr.City = "Indapur";

            Console.WriteLine(a.Id+"  "+ a.Name+"  "+ a.Adr.Pincode+" "+ a.Adr.City);

                
        }
    }
}
