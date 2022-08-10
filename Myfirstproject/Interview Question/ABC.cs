using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interview_Question
{  // Palindrome number  
    class ABC
    {
        public static void Main(string[] args)
        {
            int n, num, r, rev = 0;

            Console.Write("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            num = n;

            while (n > 0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }

            if (num == rev)
            {
                Console.WriteLine("Number is palindrome:" + num);
            }
            else
            {
                Console.WriteLine("Number is not palindrome:" + num);
            }
        }
    }
}  
