using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.lib.Medium
{
    public class ThreeSumClass
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> rslt = new();
            if (nums.Length < 3)
                return new List<IList<int>> { };


            if (nums.All(i => i == 0))
            {
                rslt.Add(new List<int> { 0, 0, 0 });
                return rslt;
            }

            nums = nums.OrderBy(i => i).ToArray();
            int val = 0, tmp = 0;
            int front = 0, end = 0;

            for (var i = 0; i < nums.Length - 2; i++)
            {
                tmp = nums[i];
                front = i + 1;
                end = nums.Length - 1;

                if (i == 0 || nums[i] != nums[i - 1])
                {

                    while (end > front)
                    {
                        val = tmp + nums[front] + nums[end];

                        if (val == 0)
                        {
                            rslt.Add(new List<int> { nums[i], nums[front], nums[end] });
                            front++;
                            end--;

                            while (front < end && nums[front] == nums[front - 1]) front++;
                            while (front < end && nums[end] == nums[end + 1]) end--;
                        }
                        else if (val < 0)
                        {
                            front++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }

            return rslt;
        }
    }
}