using System;
using System.Collections.Generic;

public class Solution
{
    private int SqrtSum(int number)
    {
        int totalSum = 0;
        while (number > 0)
        {
            int value = number % 10;
            totalSum += value * value;
            number /= 10;
        }
        return totalSum;
    }

    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();
        int value = n;

        while (value != 1 && !seen.Contains(value))
        {
            seen.Add(value);
            value = SqrtSum(value);
        }

        return value == 1;
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        int n = 19; // Example input
        bool result = solution.IsHappy(n);
        Console.WriteLine($"Is {n} a happy number? {result}");
    }
}
