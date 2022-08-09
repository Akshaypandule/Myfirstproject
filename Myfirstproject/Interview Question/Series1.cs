using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interview_Question
{ // 2,3,5,9,17,33,65
    class Series1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n;i++)
            { 
                int b = (i *2)-1;
               
                Console.WriteLine(b);
               
            }
        }
        
        
    }
    class Series2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i = i * 2)
            {
                int b = (i + i) - 1;

                Console.WriteLine(b);
                
            }
        }


    }
}
