using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class frq
    {
        public static void countFreq(int[] arr, int n)
        {
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (visited[i] == true)
                    continue;
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            int[] ar = new int[a];
            for (int i = 0; i < a; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
          //  frq.countFreq(a);
        }


    }   
        
    
}
