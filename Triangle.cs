using System;

class Triangle
{

    private int x;
    private int y;
    private int z;

    public Triangle(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public Triangle() { }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public int Z
    {
        get { return z; }
        set { z = value; }
    }

    public void ShowInfo()
    {
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("z = " + z);
    }

    public void TestTriangle()
    {
        if (x == y && y == z)
            Console.WriteLine("Triangle is equilateral");
        else if (x == y || x == z || y == z)
            Console.WriteLine("Triangle is isosceles");
        else
            Console.WriteLine("Triangle is scalene");
    }

}
