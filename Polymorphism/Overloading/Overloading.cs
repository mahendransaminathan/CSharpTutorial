

class OverloadingExample
{
    public void display(int a, int b)
    {
        Console.WriteLine("Displaying int values: " + a + ", " + b);
    }
    public void display(string a, string b)
    {
        Console.WriteLine("Displaying string values: " + a + ", " + b);
    }

    public void display(double a, double b)
    {
        Console.WriteLine("Displaying double values: " + a + ", " + b);
    }
    public void display(int a, string b)
    {
        Console.WriteLine("Displaying int and string values: " + a + ", " + b);
    }
    public void display(string a, int b)
    {
        Console.WriteLine("Displaying string and int values: " + a + ", " + b);
    }
}