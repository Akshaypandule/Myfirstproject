using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{
    interface Ifacable
    {
        public void Display(int a);
    }
    class SumFActor : Ifacable
    {
        public void Display(int a)
        {
            int sum = 0;
            for(int i=1;i<=a;i++)
            {
                if(a%i==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of factor is="  + sum);

        }
    }
    class factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            SumFActor b = new SumFActor();
            b.Display(a);
        }
    }
        
    
}
