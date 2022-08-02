using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulate
{
    class Storeincome
    {
        string store_name;
        int perday_income;
        int day;
        int total_income;

        Storeincome(string store_name,int perday_income,int day)
        {
            this.store_name = store_name;
            this.perday_income = perday_income;
            this.day = day;
        }
        Storeincome():this("cartmax",60000,25)
        {
            total_income = perday_income * day;
            this.display();
        }
        void display()
        {
            Console.WriteLine(store_name+" "+ perday_income+" "+ day);
        }
        static void main(string[]args)
        {
            Storeincome d = new Storeincome();
        }


    }
    
    

    
}
