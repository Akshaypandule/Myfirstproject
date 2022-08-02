using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Switch
{
    class Daynumberswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:Console.WriteLine("monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wednesday");
                    break;
                case 4:Console.WriteLine("Thurday");
                    break;
                case 5:Console.WriteLine("Friday");
                    break;
                case 6:Console.WriteLine("Saturday");
                    break;
                case 7:Console.WriteLine("Sunday");
                    break;
                default:Console.WriteLine("invalid");
                    break;

                        
            }



        }
    }
}
