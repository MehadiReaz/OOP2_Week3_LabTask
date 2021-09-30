
using System;

class Course
{

    private string courseName;
    private string courseCode;
    private int courseCredit;

    public Course(string courseName, string courseCode, int courseCredit)
    {
        this.courseName = courseName;
        this.courseCode = courseCode;
        this.courseCredit = courseCredit;
    }
    public Course() { }

    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    public string CourseCode
    {
        get { return courseCode; }
        set { courseCode = value; }
    }

    public int CourseCredit
    {
        get { return courseCredit; }
        set { courseCredit = value; }
    }

    public void ShowCourseInfo()
    {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Course Code: " + courseCode);
        Console.WriteLine("Course Credits: " + courseCredit);
    }
}
