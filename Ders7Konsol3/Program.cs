using Ders7Konsol3;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Association

namespace Ders7Konsol3
{
    class Teacher
    {
        public string name;
    }

    class Student
    {
        public string studentName;
        public Teacher teacher;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.name = "Ahmet Hoca";

            Student s1 = new Student();
            s1.studentName = "Zehra";
            s1.teacher = t1;

            Console.WriteLine(s1.studentName);
            Console.WriteLine(s1.teacher.name);
        }
    }
}
        
  




