using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leetcode.lib.Easy;
using Xunit;

namespace leetcode.test.Easy
{
    public class NumberOfStepsToReduceANumberToZeroTest
    {
        [Theory]
        [InlineData(14, 6)]
        [InlineData(8, 4)]
        [InlineData(123, 12)]
        public void Test(int num, int expected)
        {
            var obj = new NumberOfStepsToReduceANumberToZero();

            var rslt = obj.NumberOfSteps(num);

            Assert.Equal(expected, rslt);
        }
    }
}