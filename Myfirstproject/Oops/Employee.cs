using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops
{

    class Employee
    {
        public int id;
        public string name;
        public double salary;
        public string address;
        public void Acceptdetalis(int eid,string ename,double sal,string adr)
        {
            id = eid;
            name = ename;
            salary = sal;
            address = adr;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary + " " + address);
        }
        static void Main(string[]args)
        {
            Employee e = new Employee();
            e.Acceptdetalis(1, "Akshay", 350000.985, "Indapur");
            e.Display();
        }
    }
}
