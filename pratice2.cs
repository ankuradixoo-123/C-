public class Solution
{
    public int TrailingZeroes(int n)
    {
        int result = 0;
        for (long i = 5; n / i > 0; i *= 5)
        {
            result += (int)(n / i);
        }
        return result;
    }
}


public class Program
{
    public static void Main() 
    {
        Solution solution = new Solution();
        int n = 13; 
        int trailingZeroes = solution.TrailingZeroes(n);
        Console.WriteLine($"Number of trailing zeroes in {n}! is {trailingZeroes}");
    }
}
