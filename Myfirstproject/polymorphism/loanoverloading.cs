using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.polymorphism
{
    class loanoverloading
    {
        // int num, num1, num2;
        double total1, total2;
        int p = 150000; int n;
        public void Claculate_intrate(float f1)
        {
            total1 = p * n * f1 / 100;
            Console.WriteLine(total1);

        }
        public void calculate_intrate(float f2, float f1)
        {
            if (n > 6)
            {
                Console.WriteLine(total1 = p * n * f2 / 100);
            }
            else
                Console.WriteLine(total1 = p * n * f1 / 100);


        }
        static void Main(string[] args)
        { 
            loanoverloading b = new loanoverloading();
            b.calculate_intrate(23,65);
        }
    }
}

