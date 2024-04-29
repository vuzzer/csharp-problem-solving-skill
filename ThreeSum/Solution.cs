using System;
namespace ThreeSum
{
	public class Solution
	{
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> solutions = new List<List<int>>();

            Array.Sort(nums);

            for (int p = 0; p < nums.Length; p++)
            {
                if (p > 0 && nums[p - 1] == nums[p])
                    continue;
                int l = p + 1;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int threesum = nums[p] + nums[l] + nums[r];
                    if (threesum > 0)
                    {
                        r -= 1;
                        while (r > 0 && nums[r + 1] == nums[r])
                        {
                            r -= 1;
                        }
                    }
                    else if (threesum < 0)
                    {
                        l += 1;
                        while (l < nums.Length - 1 && nums[l] == nums[l - 1])
                        {
                            l += 1;
                        }
                    }
                    else
                    {
                        solutions.Add(new List<int> { nums[p], nums[l], nums[r] });
                        l += 1;
                        while (l < nums.Length - 1 && nums[l] == nums[l - 1])
                        {
                            l += 1;
                        }
                    }
                }
            }
            IList<IList<int>> Isolutions = solutions.Cast<IList<int>>().ToList();
            return Isolutions;
        }
    }
}

