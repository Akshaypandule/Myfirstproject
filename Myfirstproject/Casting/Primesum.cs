using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Casting
{
    class Primesum
    {
        int SumOfPrime (int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                bool isprime = true;
                for (int j = 2; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    sum = sum + i;
                }

            }
            return sum;

        }

        static void Main(string[] args)
        {
            Primesum d = new Primesum();
            int sum = d.SumOfPrime(20);
            Console.WriteLine(sum);


        }
    }
}

