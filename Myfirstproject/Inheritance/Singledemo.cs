using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{

    class mobile
    {
        internal string memory_size = "64GB";
    }
    class Apple:mobile
    {
       public void show()
        {
            Console.WriteLine(memory_size);
        }
    }
    class Singledemo
    {
        static void Main(string[]args)
        {
            Apple iphone = new Apple();
            iphone.show();
            Console.WriteLine(iphone.memory_size);

        }
    }
}
