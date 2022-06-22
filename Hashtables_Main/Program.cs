// using System;
using System.Collections;

namespace Hashtables
{


    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Chaz", 3.5f);
            Student stud2 = new Student(2, "Carey", 3.5f);
            Student stud3 = new Student(3, "Kahne", 3.5f);
            Student stud4 = new Student(4, "Nox", 3.5f);
            Student stud5 = new Student(5, "Scribbs", 3.5f);
            Student stud6 = new Student();

            studentsTable.Add(stud1.ID, stud1);
            studentsTable.Add(stud2.ID, stud2);
            studentsTable.Add(stud3.ID, stud3);
            studentsTable.Add(stud4.ID, stud4);
            studentsTable.Add(stud5.ID, stud5);


            Student storedStudent1 = (Student)studentsTable[stud6.ID];

            Console.WriteLine($"{stud6.ID} // {stud6.Name}");
            Console.Read();
        }

        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }

            public Student(int id, string name, float gpa)
            {
                this.ID = id;
                this.Name = name;
                this.GPA = gpa;
            }

            public Student()
            {
                this.ID = 0;
                this.Name = "None";
                this.GPA = 0;
            }

        }

    }
}