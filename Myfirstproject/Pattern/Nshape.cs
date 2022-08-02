using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Pattern
{
    class Nshape
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
               for(int i=0;i<num;i++)
            {
                for(int j=0;j<num;j++)
                {
                    if (j==0||j==num-1||i==j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }Console.WriteLine();
            }
        }
    }
}
