using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.lib.Medium
{
    /*
    The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
    (you may want to display this pattern in a fixed font for better legibility)
    P   A   H   N
    A P L S I I G
    Y   I   R
    And then read line by line: "PAHNAPLSIIGYIR"

    Write the code that will take a string and make this conversion given a number of rows:

    string convert(string s, int numRows);
    Example 1:
    Input: s = "PAYPALISHIRING", numRows = 3
    Output: "PAHNAPLSIIGYIR"

    Example 2:
    Input: s = "PAYPALISHIRING", numRows = 4
    Output: "PINALSIGYAHRPI"
    Explanation:

    P     I    N
    A   L S  I G
    Y A   H R
    P     I
    */
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            if (numRows == 1)
                return s;
            bool godown = false;
            int num = 0;
            List<StringBuilder> list = new List<StringBuilder>();

            for (var index = 0; index < numRows; index++)
                list.Add(new StringBuilder());

            for (var i = 0; i < s.Length; i++)
            {
                list[num].Append(s[i]);
                if (num == 0 || num == numRows - 1) godown = !godown;
                num += godown ? 1 : -1;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
                sb.Append(item.ToString());

            return sb.ToString();
        }

        public string ConvertV2(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            if (numRows == 1)
                return s;

            var length = numRows * 2 - 2;
            StringBuilder sb = new StringBuilder();
            int index = 0;

            for (var i = 0; i < numRows; i++)
            {
                for (var j = i; j < s.Length; j += length)
                {
                    sb.Append(s[j]);
                    if (i != 0 && i != numRows - 1 &&
                      (index = j - i + (length - i)) < s.Length)
                    {
                        sb.Append(s[index]);
                    }
                }
            }

            return sb.ToString();
        }


        public string ConvertV3(string s, int numRows)
        {
            var sb1 = new StringBuilder("");

            int currentIndex = 0, currentRow = numRows;

            if (s.Length == 1 || numRows < 2) return s;

            while (currentRow > 0)
            {

                int i = 0;

                for (int j = currentIndex; j < s.Length;)
                {

                    if (i % 2 == 0 && (currentRow - 1) != 0)
                    {

                        sb1.Append(s[j]);

                        j += (currentRow - 1) * 2;


                    }
                    else if (i % 2 != 0 && numRows != currentRow)
                    {
                        sb1.Append(s[j]);
                        j += (numRows - currentRow) * 2;
                    }

                    i++;
                }

                currentRow--;
                currentIndex++;
            }

            return sb1.ToString();
        }
    }
}