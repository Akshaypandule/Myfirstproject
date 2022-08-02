using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test1
{
    class Happy
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter num");
            int n = int.Parse(Console.ReadLine());
            bool ishappy = true;
            while(n!=0)
            {
                if(n%2==0)
                {
                    ishappy = false;
                }
                n /= 10;
            }
            if (ishappy == true)
            {
                Console.WriteLine(n + " is happy num");
            }
            else
            {
                Console.WriteLine(" not happy num");
            }
                

        }
    }
}
