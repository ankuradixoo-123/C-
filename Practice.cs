using System;
using System.Collections.Generic;

public class Solution
{
    public void Rotate(List<int> nums, int k)
    {
        int n = nums.Count;
        List<int> temp = new List<int>(new int[n]);

        for (int i = 0; i < n; i++)
        {
            temp[(i + k) % n] = nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = temp[i];
        }
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        solution.Rotate(nums, k);
        Console.WriteLine("Rotated array: " + string.Join(", ", nums));
    }
}
