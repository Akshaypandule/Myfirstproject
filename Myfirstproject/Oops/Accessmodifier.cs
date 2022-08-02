using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{
    class Accessmodifier
    {
        int roll_num = 45;                      //private type -Does not show any other class.
        internal string name = "Akshay";      //  internal type- other class but same namespace.
        protected double per=71.45; //the type or member can be accessed only by code in the same class, or in a class that is derived from that class.
        public string Add = "ABC"; // show any class,other project same namespace other name space. mens public

        public void print_Add()
        {
            Console.WriteLine("Address");
        }
        protected void print_per()
        {
            Console.WriteLine("percentage"+per);
        }

        void printRoll()
        {
            Console.WriteLine(" roll number" + roll_num);
        }
        internal void print_name()
        {
            Console.WriteLine(" name " + name);
        }
        static void Main(string[] args)
        {
            Accessmodifier a = new Accessmodifier();
            Console.WriteLine(a.roll_num);
            a.printRoll();

            Console.WriteLine(a.name);
            a.print_name();

            Console.WriteLine(a.per);
            a.print_per();

            Console.WriteLine(a.Add);
            a.print_Add();
        }

    } 
    
}
