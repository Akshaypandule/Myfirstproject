using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    //Hierarchical inheritance
    class Teacher
    {
        public string SubjectName = "Subject";
        public string TeacherName = "Name";

    }
    class Physics:Teacher
    {
        public void showPhysics()
        {
            SubjectName = "Physics";
            TeacherName = "Akash Sir";
            Console.WriteLine(SubjectName+"  "+ TeacherName);
        } 
    }
    class Chemistry:Teacher
    {
        public void showChemistry()
        {
            SubjectName = "Chemistry";
            TeacherName = "Sandip Sir";
            Console.WriteLine(SubjectName+ " "+ TeacherName);
        }
    }
    class Math:Teacher
    {
        public void showMath()
        {
            SubjectName = "Math";
            TeacherName = "Mahesh Sir";
            Console.WriteLine(SubjectName+ " "+TeacherName);
        }

    }
    class Biology:Teacher
    {
        public void showBiology()
        {
            SubjectName = "Biology";
            TeacherName = "Shekhar sir";
            Console.WriteLine(SubjectName+ "  "+TeacherName);
        }
    }
    class Hierarchical
    {
        static void Main(string[] args)
        {
            Physics a = new Physics();
            a.showPhysics();
            Chemistry b = new Chemistry();
            b.showChemistry();
            Math c = new Math();
            c.showMath();
            Biology d = new Biology();
            d.showBiology();
        }
    }
}
