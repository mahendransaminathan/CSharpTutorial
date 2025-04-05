
class Collections
{
    public void ListFunctions()
    {
        List<int> numbers = new List<int> {1, 2, 3, 4, 5 };

        numbers.Add(6); // Add an element to the list
        numbers.Remove(3); // Remove an element from the list
        numbers.Insert(2, 10); // Insert an element at a specific index
        numbers.Sort(); // Sort the list in ascending order
        numbers.Reverse(); // Reverse the order of the list
        
        foreach (var number in numbers)
        {
            Console.WriteLine("Displaying List Number: " + number); // Output: 6, 5, 4, 2, 1, 10
        }
    }

    public void DictionaryFunctions()
    {
        Dictionary<string, int> studentAges = new Dictionary<string, int>();
   
        studentAges.Add("John", 20);
        studentAges.Add("Sara", 22);
        studentAges.Add("Tom", 24);
        studentAges.Add("Mike", 23);
        studentAges.Add("Anna", 25);

        studentAges.Remove("Tom"); // Remove an element from the dictionary
        studentAges["John"] = 21; // Update an element in the dictionary
        
        foreach (var student in studentAges)
        {
            Console.WriteLine("Displaying Student Name:" + student.Key + ", Age: " + student.Value); // Output: John, 20; Sara, 22; Tom, 24; Mike, 23; Anna, 25

        }
    }


    public void HashSetFunctions()
    {
        HashSet<String> studentNames = new HashSet<string> { "John", "Sara", "Tom", "Mike", "Anna" };
        studentNames.Add("John"); // Add an element to the HashSet
        studentNames.Add("Sara"); // Add an element to the HashSet
        studentNames.Add("Tom"); // Add an element to the HashSet
        studentNames.Add("Mike"); // Add an element to the HashSet
        studentNames.Add("Anna"); // Add an element to the HashSet
        studentNames.Add("John"); // Duplicate, will not be added
        studentNames.Remove("Tom"); // Remove an element from the HashSet
        studentNames.Add("Tom"); // Add an element to the HashSet
        studentNames.Add("Sara"); // Duplicate, will not be added
        studentNames.Add("Mike"); // Duplicate, will not be added

        studentNames.Add("Anna"); // Duplicate, will not be added

        foreach (var name in studentNames)
        {
            Console.WriteLine("Displaying Student Name: " + name); // Output: John, Sara, Tom, Mike, Anna
        }

    }



}