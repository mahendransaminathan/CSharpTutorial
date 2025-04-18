int[] A = { 1, 3, 6, 4, 1, 2 };
int result = solution(A);
Console.WriteLine(result); // Output: 5

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
