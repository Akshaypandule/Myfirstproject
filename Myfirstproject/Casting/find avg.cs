using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Casting
{
    class find_avg
    {
        double Avg(int n)
        {
            double sum = 0;
            int count = 0;
            for (int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    sum = sum + i;
                    count++; 
                }
            }
            double avg = (sum / count);
            return avg;

        }
        static void Main(string[] args)
        {
            find_avg a = new find_avg();

            Console.WriteLine(a.Avg(9));
        }
    }
}
