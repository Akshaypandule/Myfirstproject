using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Switch
{
    class oddevenswitch
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num%2)
            {
                case 0:Console.WriteLine( num +   "number is even");
                    break;
                case 1:Console.WriteLine(num + " number is odd");
                    break;
                default:Console.WriteLine("invalid");
                    break;

            }
        }
    }
}
