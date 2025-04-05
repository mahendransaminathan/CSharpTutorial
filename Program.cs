// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        // Shape myShape = new Circle(5);
        // // myShape.Describe(); // This will call the Describe method from the Shape class
        // Console.WriteLine("Area of the circle: " + myShape.GetArea());
    
        // IShape myRectangle = new Rectangle(4, 5);
        // myRectangle.Describe(); // This will call the Describe method from the IShape interface
        // Console.WriteLine("Area of the rectangle: " + myRectangle.GetArea());

        // LinqExample linqExample = new LinqExample(); // Uncomment to run LINQ example
        // linqExample.EvenNumbers(); // Uncomment to run LINQ example

        // linqExample.studentsFromNewYork(); // Uncomment to run LINQ example
        // linqExample.studentsName(); // Uncomment to run LINQ example
        // linqExample.studentsAge(); // Uncomment to run LINQ example
        // linqExample.studentsAgeByAscending(); // Uncomment to run LINQ example
        // linqExample.studentsAgeByCondition(); // Uncomment to run LINQ example
        

        // Collections collectionsExample = new Collections(); // Uncomment to run Collections example
        // collectionsExample.ListFunctions(); // Uncomment to run Collections example
        // collectionsExample.DictionaryFunctions(); // Uncomment to run Collections example
        // collectionsExample.HashSetFunctions(); // Uncomment to run Collections example

        ADONetExample aDONetExample = new ADONetExample(); // Uncomment to run ADO.NET example
        aDONetExample.ConnectToDatabase(); // Uncomment to run ADO.NET example

        staticExample staticExample = new staticExample(); // Uncomment to run Static example

        Console.WriteLine("Static Variable: " + staticExample.StaticMethod()); // Uncomment to run Static example
        Console.WriteLine("Static Field: " + staticExample.x); // Uncomment to run Static example

    }
}