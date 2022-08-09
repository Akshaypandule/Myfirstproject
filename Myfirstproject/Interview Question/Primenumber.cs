using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interview_Question
{
    class Primenumber
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {

                Console.WriteLine("enter the number");
                 num = int.Parse(Console.ReadLine());
                int a = 10;

                if (num < 0)
                {
                    Console.WriteLine("Negative");
                    break;
                }
                for (int i = 2; num >= i; i++)
                {
                    if (num % i == 0)
                    {
                        a = 1;
                        break;
                    }
                    if (a == 10)
                    {
                        Console.WriteLine("  " + num);
                    }
                }


            }
        }

        }

    } 

