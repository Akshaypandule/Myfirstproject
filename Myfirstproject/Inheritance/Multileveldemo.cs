using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    class person
    {
        internal string P_name = "Akshay";

        public void showPerson()
        {
            Console.WriteLine("Name-" +P_name);
        }
    }
    class Employee:person
    {
        internal int salary = 65000;
        public void showSalary()
        {
            Console.WriteLine(P_name+" "+salary);
        }
    }
    class Manger:Employee
    {
        int commition = 60000;
        public void showManger()
        {
            Console.WriteLine(P_name+" "+salary+" "+commition);
        }
    }
    class Multileveldemo
    {
        static void Main(string[] args)
        {
            Manger a = new Manger();
            a.showPerson();
            a.showManger();
            a.showSalary();
;        }
    }
}
