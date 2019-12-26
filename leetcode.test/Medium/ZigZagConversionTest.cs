using leetcode.lib.Medium;
using Xunit;

namespace leetcode.test.Medium
{
    public class ZigZagConversionTest
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        public void Test(string input, int rowNumber, string expected)
        { 
            var actul = new ZigZagConversion();

            var rslt = actul.Convert(input, rowNumber);

            Assert.Equal(expected, rslt);
        }
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        public void TestV2(string input, int rowNumber, string expected)
        { 
            var actul = new ZigZagConversion();

            var rslt = actul.ConvertV2(input, rowNumber);

            Assert.Equal(expected, rslt);
        }
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        public void TestV3(string input, int rowNumber, string expected)
        { 
            var actul = new ZigZagConversion();

            var rslt = actul.ConvertV3(input, rowNumber);

            Assert.Equal(expected, rslt);
        }
    }
}