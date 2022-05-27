using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.lib.Easy
{
    public class NumberOfStepsToReduceANumberToZero
    {
        public int NumberOfSteps(int num)
        {
            var s = Convert.ToString(num, 2).ToArray();
            int v = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '0') v++;
                else v += 2;
            }
            return --v;
        }
    }
}