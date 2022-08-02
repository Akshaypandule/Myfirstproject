using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmentno1
{
    class Findmaximum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num3");
            num3 = int.Parse(Console.ReadLine());

            if (num1>num2&&num1>num3)
            {
                Console.WriteLine(num1);
            }
            else if(num3>num2&&num3>num1)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
