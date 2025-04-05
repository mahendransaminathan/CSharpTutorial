
using System;
using System.Collections.Generic;
using System.Linq;

class student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string City { get; set; }
}
class LinqExample
{

    // Example 2: Using LINQ to filter a list of students
    List<student> students = new List<student>
    {
        new student { Name = "John", Age = 20, City = "New York" },
        new student { Name = "Jane", Age = 22, City = "Los Angeles" },
        new student { Name = "Mike", Age = 21, City = "Chicago" },
        new student { Name = "Sara", Age = 23, City = "New York" },
        new student { Name = "Tom", Age = 24, City = "Los Angeles" },
        new student { Name = "Anna", Age = 25, City = "Chicago" }
    };

    List<student> studentsFromNY;

    public void studentsFromNewYork()
    {
        studentsFromNY = students.Where(s => s.City == "New York").ToList();

        foreach (var student in studentsFromNY)
        {
            Console.WriteLine("Displaying Student from New York: " + student.Name); // Output: John, Sara
        }
    }

    public void studentsName()
    {
        List<string> studentNames = students.Select(s => s.Name).ToList();

        foreach (var name in studentNames)
        {
            Console.WriteLine("Displaying Student Name: " + name);
        }
    }

    public void studentsAge()
    {
        List<int> orderedAges = students.Select(s => s.Age).OrderBy(age => age).ToList();
    
        foreach(var age in orderedAges)
        {
            Console.WriteLine("Displaying Student Age: " + age); // Output: 20, 21, 22, 23, 24, 25
        }
    }

    public void studentsAgeByAscending()
    {
        List<int> orderedAges = students.Select(s => s.Age).OrderByDescending(age => age).ToList();
    
        foreach(var age in orderedAges)
        {
            Console.WriteLine("Displaying Student Age: " + age); // Output: 25, 24, 23, 22, 21, 20
        }
    }

    public void studentsAgeByCondition()
    {
        var studentName = students.First(s => s.Age > 22).Name;
        Console.WriteLine("Displaying Student Name: " + studentName); // Output: Tom
    }

    

            // Example 1: Using LINQ to filter a list of integers
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    List<int> evenNumbers;

    public void EvenNumbers()
    {
        evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        foreach (var number in evenNumbers)
        {
            Console.WriteLine("Displaying Even Number: " + number); // Output: 2, 4
        }
    }
    
}


