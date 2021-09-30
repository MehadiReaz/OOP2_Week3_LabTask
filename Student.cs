using System;

class Student
{

    private string name;
    private string id;
    private string department;
    private float cgpa;


    public Student(string name, string id, string department, float cgpa)
    {
        this.name = name;
        this.id = id;
        this.department = department;
        this.cgpa = cgpa;
    }
    public Student() { }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public float CGPA
    {
        get { return cgpa; }
        set { cgpa = value; }
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("CGPA: " + cgpa);
    }
}
