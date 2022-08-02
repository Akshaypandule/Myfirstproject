using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.polymorphism
{
    class Mobile
    {
        int price;
        string name;
        string memory;

        public Mobile()
        {
            Console.WriteLine("default");
        }
        public Mobile(string name)
        {
            this.name = name;

        }
        public void show()
        {
            Console.WriteLine(name);
        }
        public Mobile(int price,string memory)
        {
            this.price = price;
            this.memory = memory;

        }
        public void show1()
        {
            Console.WriteLine(price  +"   "+  memory);
        }
    }
    class constructoverloading
    {

        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            Mobile m1 = new Mobile("Apple");
            Mobile m2 = new Mobile(450000, "64GB");

            m.show();
            m.show1();
            
        }

 
    }
            

}
