// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Circle(5);
        // myShape.Describe(); // This will call the Describe method from the Shape class
        Console.WriteLine("Area of the circle: " + myShape.GetArea());
    
        IShape myRectangle = new Rectangle(4, 5);
        myRectangle.Describe(); // This will call the Describe method from the IShape interface
        Console.WriteLine("Area of the rectangle: " + myRectangle.GetArea());

         LinqExample linqExample = new LinqExample(); // Uncomment to run LINQ example
         linqExample.EvenNumbers(); // Uncomment to run LINQ example
    }
}