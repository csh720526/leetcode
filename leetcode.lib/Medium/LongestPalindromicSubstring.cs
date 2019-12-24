using System;

namespace leetcode.lib.Medium
{
    public class LongestPalindromicSubstring
    {

        /*
        abcdefbcbij
        0123456789
        */
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            int length = 0;
            int start = 0;
            int end = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var n1 = FindLength(s, i, i);
                var n2 = FindLength(s, i, i + 1);

                length = Math.Max(n1, n2);

                if (length > end - start)
                {
                    start = i - ((length - 1) / 2);
                    end = i + (length / 2);
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int FindLength(string s, int left, int right)
        {
            int l = left;
            int r = right;

            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }

            return r - l - 1;
        }
    }
}