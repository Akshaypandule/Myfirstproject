using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Casting
{
    class Primetrue
    {
        bool IsPrimenumber(int n)
        {
            bool isprime = true;
            for (int i =2; i<n; i++) 
            {
                if (n%i==0)
                {
                    isprime = false;
                    break;    
                }
            }
            return isprime;


        }
        static void Main(string[] args)
        {
            Primetrue d = new Primetrue();
            bool b = d.IsPrimenumber(25);
            if (b == true)
            {
                Console.WriteLine("prime number");
            }
            else if (b == false)
            {
                Console.WriteLine("not prime number");
            }
        }
    }
   
}