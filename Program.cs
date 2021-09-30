using System;

namespace OOP2_Week3_LabTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Reaz", "20-42841-1", "CSE", 3.75f);
            s1.ShowInfo();

            Triangle t1 = new Triangle(5, 10, 15);
            t1.ShowInfo();
            t1.TestTriangle();

            Account a1 = new Account("Reaz", "7656389", 50000);
            a1.ShowAccountInfo();

            Course c1 = new Course("OOP2", "CS345", 3);
            c1.ShowCourseInfo();

        }
    }
}