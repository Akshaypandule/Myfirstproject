﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Switch
{
    class Vowelswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':Console.WriteLine("vowel");
                    break;
                case 'E':Console.WriteLine("vowel");
                    break;
                case 'I':Console.WriteLine("vowel");
                    break;
                case 'O':Console.WriteLine("vowel");
                    break;
                case 'U':Console.WriteLine("vowel");
                    break;
                default:Console.WriteLine("Consonent");
                    break;
            }
        }
    }
}
