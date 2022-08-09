using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{
    interface IDrawable
    {
        void Draw();
    }
    interface Iprintable
    {
        void Print();
    }
    class Shape : IDrawable, Iprintable
    {
        public void Draw()
        {
            Console.WriteLine("Draw Shape");
        }
        public void Print()
        {
            Console.WriteLine("Print shape");
        }
       /* static void Main(string[] args)
        {
            Shape a = new Shape();
            a.Draw();
            a.Print();

        }*/

    } 

    class InterfaceDemo
{
         static void Main(string[] args)
    {
        Shape a = new Shape();
        a.Draw();
        a.Print();
    }
}
}
