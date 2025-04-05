interface IShape
{

    double GetAreas()
    {
        return 0; // Default implementation, can be overridden
    }
    double Describe();
}

class Rectangle : IShape
{
    private double width;
    private double height;

    public int id { get; set; } // Property for id

    protected double radius;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetAreas()
    {
        return width * height;
    }

    public double Describe()
    {
        Console.WriteLine("This is a rectangle.");
        return 0; // Just to satisfy the interface requirement
    }
}