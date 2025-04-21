

class TwoSum
{
    static void Main(string[] args)
    {
        // Example usage
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSums(nums, target);
        Console.WriteLine("Indices of the two numbers are: " + string.Join(", ", result)); // Output: [0, 1]
    }


    public static int[] TwoSums(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
                
            }

            if (!numDict.ContainsKey(nums[i]))
            {
                numDict[nums[i]] = i;
            }            
        }
        return new int[0]; // Return an empty array if no solution is found
    }
}