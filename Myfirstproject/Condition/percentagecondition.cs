using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Condition
{
    class percentagecondition
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("enter marathi sub marks");
            int marathi = int.Parse(Console.ReadLine());
            Console.WriteLine("enter eng sub marks");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("enter math sub marks");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sci sub marks");
            int sci = int.Parse(Console.ReadLine());
            Console.WriteLine("enter his sub marks");
            int his = int.Parse(Console.ReadLine()); 
            int sum = marathi + eng + math + sci + his;
            int percent = sum / 5;
            Console.WriteLine(percent+       "%");
            if(percent>70)
            {
                Console.WriteLine("distinction");
            }
            else if(percent<=70 && percent>60)
            {
                Console.WriteLine("Firstclass");
            }
            else if(percent<=60 && percent>=50)
            {
                Console.WriteLine("Second class");
            }
            else if(percent<=50 && percent>=35)
            {
                Console.WriteLine("pass");
            }
            else if(percent<35)
            {
                Console.WriteLine("fail");
            }

        }
    }
}
