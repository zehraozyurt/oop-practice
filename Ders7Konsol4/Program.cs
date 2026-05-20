using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aggregation
namespace Ders7Konsol4
{
    class Student                  // Student adında sınıf oluşturuldu
    {
        public string name;        // Öğrencinin adını tutacak değişken

        public Student(string name) // Constructor (nesne oluşurken çalışır)
        {
            this.name = name;       // Sınıftaki name değişkenine gelen name değerini ata
        }
    }

    class University                    // University adında sınıf oluşturuldu
    {
        public List<Student> students;  // Student nesnelerini tutacak liste

        public University(List<Student> students) // Constructor
        {
            this.students = students; // Sınıftaki students değişkenine gelen listeyi ata
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student s1 = new Student("Zehra");
                Student s2 = new Student("Baho");

                List<Student> list = new List<Student>();
                list.Add(s1);
                list.Add(s2);

                University u1 = new University(list);

                foreach (Student s in u1.students)
                {
                    Console.WriteLine(s.name);
                }
            }
        }
    }
}
