using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{
    abstract class Animal
    {
        public abstract void Eat();
    }
    class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine(" Dog eatting");
        }
    }

    class Demo1
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            a.Eat();
        }
    }
}
