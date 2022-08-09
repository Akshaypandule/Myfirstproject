using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class Bulb
    {
        internal string bulbCapacity = "12W";
        internal int price = 120;
    }
    class SyskaLED:Bulb
    {
        public void show()
        {
            Console.WriteLine(bulbCapacity+"  "+price);
        }
    }
    class Singlelevel
    {
        static void Main(string[] args)
        {
            SyskaLED a = new SyskaLED();
            a.show();
        }
    }
}
