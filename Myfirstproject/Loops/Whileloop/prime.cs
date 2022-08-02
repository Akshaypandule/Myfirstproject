using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops.Whileloop
{
    class prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            bool k = true;
            for (int i=2;i<num;i++)
            {
                if(num%2!=0)
                {
                    k = false;
                    break;
                }
            }
            if(k==true)
            {
                Console.WriteLine("prime number");
            }
            else if(k==false)
            {
                Console.WriteLine("not prime number");
            }
        }
    }
}
