using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leetcode.lib.Medium;
using Xunit;

namespace leetcode.test.Medium
{
    public class LetterCombinationsTest
    {
        [Theory]
        [InlineData("23")]
        [InlineData("789")]
        public void Test1(string testData)
        {
            var obj = new LetterCombination();

            var rslt = obj.LetterCombinations(testData);

            rslt.ToList().ForEach(r => Console.WriteLine(r));
            
        }
    }
}