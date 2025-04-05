

class staticExample
{
    public static int x = 10; // Static field

    public static string StaticMethod() // Static method
    {
        Console.WriteLine("Static method called.");
        return "Static method executed."; // Return value from static method
    }

    public void StaticMethodPartial() // Partial method declaration
    {
       Console.WriteLine("Static field value: " + x); // Accessing static field
       StaticMethod(); // Calling static method
    }
}