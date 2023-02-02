using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 3.8f);
            Student stud2 = new Student(2, "ahsan", 3.8f);
            Student stud3 = new Student(3, "sumon", 3.8f);

            studentTable.Add(stud1.Id, stud1);
            studentTable.Add(stud2.Id, stud2);
            studentTable.Add(stud3.Id, stud3);

            foreach (DictionaryEntry entry in studentTable)
            {
                Student temp=(Student) entry.Value;
                Console.WriteLine("Student ID {0}", temp.Id);
                Console.WriteLine("Student Name {0}", temp.Name);
                Console.WriteLine("Student GPA {0}\n", temp.GPA) ;
            }


            foreach (Student value in studentTable.Values)
            {
                
                Console.WriteLine("Student ID {0}", value.Id);
                Console.WriteLine("Student Name {0}", value.Name);
                Console.WriteLine("\nStudent GPA {0}", value.GPA);
            }

            Student storedStudent1 = (Student)studentTable[stud1.Id];
            Console.WriteLine($"{storedStudent1.Id},{storedStudent1.Name},{storedStudent1.GPA}");
        }


    }
    class Student
    {
        public int Id { get;set;}
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id,string name,float gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }



    }
}
