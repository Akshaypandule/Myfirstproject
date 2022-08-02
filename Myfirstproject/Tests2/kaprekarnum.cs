using System ;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests2
{
    class kaprekarnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int count = 1;
            int sq = num * num;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i=1;i<count;i++)
            {
                power = power * 10;
            }
            int division = sq / power;
            int rem = sq % power;
            int sum = division + rem;
            if (sum==temp)
            {
                Console.WriteLine("kaprekr number");
            }
            else
            {
                Console.WriteLine("not kaprekr number");
            }
        }
    }
}
