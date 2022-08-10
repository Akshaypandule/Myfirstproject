using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Tests3
{//Constructor chaining...
    class Student
    {
        int age;
        string name;
        int percentage;
        public Student (int age)
        {
            this.age = age;
            Console.WriteLine(age);
        }
        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
            Console.WriteLine(age  +name);
        }
        public Student(int age,string name,int percentage)
        {
            this.age = age;
            this.name = name;
            this.percentage = percentage;
            Console.WriteLine(age +  name  +percentage);
        }
       
    }
    class Constructor1
    {
        static void Main(string[] args)
        {
            Student a = new Student(18);
            Student a1 = new Student(18,     "Abhi");
            Student a3 = new Student(18, "Abhi"    , 92);
        }

    }

}
