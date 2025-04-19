using System;
using System.Collections.Generic;

class FirstNonRepeatingCharacter
{
    static void Main(string[] args)
    {
        // Example usage
        string strSol = "swiss";

        Console.WriteLine("First Non Repeating character" + FirstNonRepeatingChar(strSol)); // Output: 'w'
    }

    static char FirstNonRepeatingChar(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();


        foreach(char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach(char c in str)
        {
            if (charCount[c] == 1)
            {
                return c;
            }
        }

        return '\0'; // Return null character if no non-repeating character is found

    }
}