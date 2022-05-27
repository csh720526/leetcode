using System.Runtime.CompilerServices;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.lib.Medium
{
    public class IntergerToRoman
    {
        // private Dictionary<char, int> Map = new()
        // {

        //     {'M', 1000}, {'D', 500},
        //     {'C', 100}, {'L', 50},
        //     {'X', 10}, {'V', 5},
        //     {'I', 1}
        // };

        private Dictionary<int, char> Map = new()
        {
            {1000, 'M'}, {500, 'D'},
            {100, 'C'}, {50, 'L'},
            {10, 'X'}, {5, 'V'},
            {1, 'I'}
        };

        private List<int> Carry = new List<int> { 1000, 100, 10 };

        public string IntToRoman(int num)
        {
            StringBuilder sb = new();
            int tmp;

            for (var i = 0; i < Carry.Count; i++)
            {
                tmp = Carry[i];
                var v1 = num / tmp;

                if (v1 > 0)
                    Handle(v1, Carry[i], sb);

                num %= tmp;
            }

            Handle(num, 1, sb);

            return sb.ToString();
        }

        private void Handle(int v1, int index, StringBuilder sb)
        {

            if (v1 + 1 == 10)
            {
                sb.Append(Map[index])
                    .Append(Map[index * 10]);
            }
            else if (v1 + 1 == 5)
            {
                sb.Append(Map[index]).Append(Map[index * 10 / 2]);
            }
            else
            {
                if (v1 >= 5)
                {
                    sb.Append(Map[index * 5]);
                    for (var j = 0; j < v1 - 5; j++)
                        sb.Append(Map[index]);
                }
                else
                {
                    for (var j = 0; j < v1; j++)
                        sb.Append(Map[index]);
                }
            }
        }
    }
}