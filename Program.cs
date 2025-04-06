// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {

        // Abstarct class and Methods example  
        Shape myShape = new Circle(5);
        myShape.Describe(); // This will call the Describe method from the Shape class
        Console.WriteLine("Area of the circle: " + myShape.GetArea());
    
        // Interface example
        IShape myRectangle = new Rectangle(4, 5);
        Rectangle myRectangle2 = new Rectangle(4, 5);
        myRectangle2.id = 1; // Setting the id property
        // myRectangle2.radius = 2; // Setting the radius property
        myRectangle.Describe(); // This will call the Describe method from the IShape interface
        Console.WriteLine("Area of the rectangle: " + myRectangle2.id);

        // Linq Example
        LinqExample linqExample = new LinqExample(); // Uncomment to run LINQ example
        linqExample.EvenNumbers(); // Uncomment to run LINQ example

        linqExample.studentsFromNewYork(); // Uncomment to run LINQ example
        linqExample.studentsName(); // Uncomment to run LINQ example
        linqExample.studentsAge(); // Uncomment to run LINQ example
        linqExample.studentsAgeByAscending(); // Uncomment to run LINQ example
        linqExample.studentsAgeByCondition(); // Uncomment to run LINQ example
        
        // Collections Example
        Collections collectionsExample = new Collections(); // Uncomment to run Collections example
        collectionsExample.ListFunctions(); // Uncomment to run Collections example
        collectionsExample.DictionaryFunctions(); // Uncomment to run Collections example
        collectionsExample.HashSetFunctions(); // Uncomment to run Collections example

        // ADO.NET Example
        ADONetExample aDONetExample = new ADONetExample(); // Uncomment to run ADO.NET example
        aDONetExample.ConnectToDatabase(); // Uncomment to run ADO.NET example

        // Static example
        staticExample staticExample = new staticExample(); // Uncomment to run Static example

        Console.WriteLine("Static Variable: " + staticExample.StaticMethod()); // Uncomment to run Static example
        Console.WriteLine("Static Field: " + staticExample.x); // Uncomment to run Static example

        //Overloading example
        OverloadingExample overloadingExample = new OverloadingExample(); // Uncomment to run Overloading example
        overloadingExample.display(5, 10); // Uncomment to run Overloading example
        overloadingExample.display("Hello", "World"); // Uncomment to run Overloading example
        overloadingExample.display(5.5, 10.5); // Uncomment to run Overloading example
        overloadingExample.display("Hello", 10); // Uncomment to run Overloading example
        overloadingExample.display(5, "World"); // Uncomment to run Overloading example
    }
}