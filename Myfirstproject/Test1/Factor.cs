using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class Factor
    {
        static void Main(string[] args)
        {
            int num, k;
            Console.WriteLine("enter the given number");
            num= int.Parse(Console.ReadLine());
            for(k=1;k<=num;k++)
            {
                if (num%k==0)
                {
                    Console.WriteLine(k);
                }
            }Console.WriteLine();
        }
                        
    }
}
