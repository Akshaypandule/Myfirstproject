using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BaseKeyword
{
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Bird is fly");
        }
    }
    class Sparrow:Bird
    {
        public void fly()
        {
            Console.WriteLine("Sparrow is fly");
            base.Fly ();
        }
    }
    class Basedemo2
    {
        static void Main(string[] args)
        {
            Sparrow a = new Sparrow();
            a.fly ();
        }
    }
}
