using leetcode.lib.Medium;
using Xunit;

namespace leetcode.test.Easy
{
    public class PalindromeNumberTest
    {
        [Fact]
        public void Test()
        {
            var actul = new PalindromeNumber();

            var rslt = actul.IsPalindromeNumber(121);

            Assert.True(rslt);
        }
    }
}