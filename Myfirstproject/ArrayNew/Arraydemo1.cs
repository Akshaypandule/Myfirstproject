using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayNew
{
    class Arraydemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            char[] ch = new char[size];
            Console.WriteLine("Enter the char");
            for (int i = 0; i < ch.Length-1; i++) // 1 way
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(ch);

            Console.WriteLine("...............");

            foreach(char c in ch)    //2 way
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(string.Join("  ", ch)); //3 way

            
        }
    }
}
