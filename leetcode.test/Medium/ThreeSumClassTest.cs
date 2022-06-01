using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leetcode.lib.Medium;
using Xunit;

namespace leetcode.test.Medium
{
    public class ThreeSumClassTest
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>()
            {
                new object[]
                {

                    new int[] {-1,0,1,2,-1,-4},
                    new List<List<int>>
                    {
                        new List<int> { -1, -1, 2},
                        new List<int> { -1, 0, 1}
                    }
                },
                new object[]
                {

                    new int[] { -1,0,1,2,-1,-4},
                    new List<List<int>>
                    {
                        new List<int> { -1, -1, 2},
                        new List<int> { -1, 0, 1}
                    }
                },
                new object[]
                {
                    new int[] { 1, 2, -2, -1},
                    new List<List<int>>
                    {
                        new List<int> { -1, -1, 2},
                        new List<int> { -1, 0, 1}
                    }
                },
                new object[]
                {
                    new int[] { -2, 0, 1, 1, 2},
                    new List<List<int>>
                    {
                        new List<int> { -1, -1, 2},
                        new List<int> { -1, 0, 1}
                    }
                }
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(int[] nums, IList<List<int>> expected)
        {
            var obj = new ThreeSumClass();

            var rslt = obj.ThreeSum(nums);
        }
    }
}