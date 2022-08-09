using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Contentment
{
    class Department
    {
        public int id;
        public string name;
        public Department(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void ShowDepartment()
        {
            Console.WriteLine(" "+id+" "+name);
        }
    }
    class Employee
    {
        int id;
        string name;
        int salary;
        Department nam;

        Employee(int id,string name,int salary,Department nam)
        {
            this .id = id;
            this .name = name;
            this.salary = salary;
            this.nam = nam;

        }
        void displayEmployee()
        {
            Console.WriteLine(id + " " + name + " " + salary);
            nam.ShowDepartment();
        }
        static void Main(string[] args)
        {
            Department a = new Department(456, "R&D");
            Employee d;
            d = new Employee(369, "Akshay", 35000, a);
            d.displayEmployee();
        }
    }
   
   
}
