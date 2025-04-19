int[] A = { 1, 3, 6, 4, 1, 2 };
int[] B = { 1, 2, 3, 4, 5, 100, 150, 200 };
int result = solution(A);
int result2 = solution(B);
Console.WriteLine(result); // Output: 5
Console.WriteLine(result2); // Output: 6

int solution(int[] A)
{
    var set = new HashSet<int>(A);

    int i = 1;
    while(true)
    {
        if (!set.Contains(i))
        {
            return i;
        }
        i++;
    }
}
