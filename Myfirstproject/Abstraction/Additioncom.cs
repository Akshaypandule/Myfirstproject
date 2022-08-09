using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{//   one abstraction and one Interface

    interface Iaddable
    {
        void Add(int a);
    }
    abstract class Abstract_class
    {
        public abstract void Add_1(int a);
    }
    class Child:Abstract_class,Iaddable
    {
        int num1, num2;
        public override void Add_1(int b)
        {
            this.num1 = b;
        }
        public void Add(int a)
        {
            this.num2 = a;
        }
        public void addition()
        {
            Console.WriteLine("addition" +this.num1+this.num2);
        }
    }
}
