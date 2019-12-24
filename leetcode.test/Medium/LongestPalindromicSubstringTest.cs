namespace leetcode.test.Medium
{
    using leetcode.lib.Medium;
    using Xunit;

    public class LongestPalindromicSubstringTest
    {
        [Theory]
        [InlineData("babad", "aba")]
        [InlineData("abccbd", "bccb")]
        [InlineData("aefkglbccbeakeid", "bccb")]
        public void LongestPalindromeTest(string data, string expected)
        {
            var acturl = new LongestPalindromicSubstring();

            var rslt = acturl.LongestPalindrome(data);

            Assert.Equal(expected, rslt);
        }
    }
}