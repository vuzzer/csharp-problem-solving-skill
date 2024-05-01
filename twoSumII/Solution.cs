using System;
namespace twoSumII
{
	public class Solution
	{
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] solutions = new int[2];
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int actualResult = numbers[left] + numbers[right];

                // Move pointer right pointer
                if (actualResult > target)
                {
                    right -= 1;
                }
                else if (actualResult < target)
                {
                    left += 1;
                }
                else
                {
                    solutions[0] = left + 1;
                    solutions[1] = right + 1;
                    break;
                }
            }
            return solutions;
        }
    }
}

