using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{
    class Grandfather
    {
        public string name = "Sanjay";
        public int salary = 45000;
        public void showgrandfather()
        {
            Console.WriteLine("Grandfather="  +name+  "Salary=" +salary );
        }
    }
    class Father:Grandfather
    {
        public string F_name = "Manoj";
        public int F_salary = 55000;
        public void showFather()
        {
            Console.WriteLine("Grandfather=" + name + "Salary=" + salary+  "Father name="  +F_name+  "Father salary"  +salary);
        }
    }
    class Son:Father
    {
        public string S_name = " Dipak";
        public void showSon()
        {
            Console.WriteLine("Grandfather=" + name + "Salary="   + salary +   "Father name=" + F_name + "Father salary" + salary+   "Son name"  +S_name);
        }
    }
    class multilevel
    {
        static void Main(string[] args)
        {
            Son a = new Son();
            a.showSon();
            a.showFather();
            a.showgrandfather();
        }
    }
}
