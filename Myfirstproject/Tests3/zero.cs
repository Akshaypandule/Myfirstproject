using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class zero
    {
        static void Main(string[] args)
        {
            while(true)
            {
                bool flag = true;
                int num = int.Parse(Console.ReadLine());
                int r = 0;
                while(num>0)
                {
                    r = num % 10;
                    if(r==0)
                    {
                        flag = false;
                        break;

                    }
                    num = num % 10;
                }
                if(flag==false)
                {
                    break;
                }
                Console.WriteLine(num);
            }
        }
    }
}
