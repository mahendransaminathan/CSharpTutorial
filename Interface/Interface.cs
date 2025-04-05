interface IShape
{
    // private double id;
    double GetArea();
    double Describe();
}

class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }

    public double Describe()
    {
        Console.WriteLine("This is a rectangle.");
        return 0; // Just to satisfy the interface requirement
    }
}