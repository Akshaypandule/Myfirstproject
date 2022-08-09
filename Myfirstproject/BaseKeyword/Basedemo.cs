using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BaseKeyword
{
    class Animal
    {
        public int legs = 4;
    }
    class Frog:Animal
    {
        public int legs = 2;
        public void show()
        {
            Console.
                WriteLine("legs="+legs+" "+"Animal legs ="+base.legs);
        }
    }
    class Dog:Animal
    {
        public void Dispaly()
        {
            Console.WriteLine("Dog legs="+base.legs);
        }
    }

    class Basedemo
    {
        static void Main(string[] args)
        {
            Frog f = new Frog();
            f.show();
            Dog d = new Dog();
            d.Dispaly();
        }
    }
}
