using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leetcode.lib.Medium;
using Xunit;

namespace leetcode.test.Medium
{
    public class IntergerToRomanTest
    {
        [Theory]
        [InlineData(978)]
        [InlineData(453)]
        [InlineData(2453)]
        [InlineData(1994)]
        public void Test1(int data)
        {
            var obj = new IntergerToRoman();

            Console.WriteLine(obj.IntToRoman(data));
        }
    }
}