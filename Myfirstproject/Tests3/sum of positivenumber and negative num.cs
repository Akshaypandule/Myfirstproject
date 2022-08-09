using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class sum_of_positivenumber_and_negative_num
    {
        static void Main(string[] args)
        {
            int positivesum = 0;
            int negativesum = 0;
            int i;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            for(i=0;i<num;i++)
            {
                num = i + 1;
                Console.WriteLine(num);
            }
            for(i=0;i<num;i++)
            {
                if (num < 0)
                {
                    negativesum += num;
                }
                else
                    positivesum += num;
            }

        }
        


        
    }
}
