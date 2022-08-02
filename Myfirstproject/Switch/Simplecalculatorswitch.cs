using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Switch
{
    class Simplecalculatorswitch
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter the any 2 number");
            double a, b;
            a=double.Parse(Console.ReadLine());
            b =double.Parse(Console.ReadLine());
            Console.WriteLine("1.+/n2.-/n3.*/n4./");
            char ch= Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+': Console.WriteLine("addition " + (a + b));
                    break;
                case '-':Console.WriteLine("substraction" + (a - b));
                    break;
                case '*':Console.WriteLine("multiplication" + (a * b));
                    break;
                case '/':Console.WriteLine("division" + (a / b));
                    break;
                default:Console.WriteLine("invalid");
                    break;
            }



        }
        

    }
}
