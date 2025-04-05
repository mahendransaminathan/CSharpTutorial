
abstract class Shape
{
    private int id;
    public abstract double GetArea();

    // public abstract int GetAbs(); // This is not needed in the abstract class

    public void Describe()
    {
        Console.WriteLine("This is a shape.");
    }
} 

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}



    
