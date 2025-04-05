

class inheritanceExample : Shape, IShape 
{

    protected double radius;

    public inheritanceExample(double radius)
    {
        this.radius = radius;
    }

    public double GetAreas()
    {
        return Math.PI * radius * radius;
    }

    public double Describe()
    {
        Console.WriteLine("This is a circle.");
        return 0; // Just to satisfy the interface requirement
    }


    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

}

class secondlevelInheritance : inheritanceExample
{
    protected double height;

    public secondlevelInheritance(double radius, double height) : base(radius)
    {
        this.height = height;
    }

    public double GetVolume()
    {
        return GetArea() * height;
    }
}

class thirdlevelInheritance : secondlevelInheritance
{
    private double width;

    public thirdlevelInheritance(double radius, double height, double width) : base(radius, height)
    {
        this.width = width;
    }

    public double GetSurfaceArea()
    {
        return 2 * (GetArea() + (width * height * radius) + (width * GetArea()));
    }
}