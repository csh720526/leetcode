using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.lib.Medium
{

    public class LetterCombination
    {

        private List<string> Rslt = new List<string>();

        private static Dictionary<char, List<string>> map = new(){
            {'2', new () {"a", "b", "c"} },
            {'3', new () {"d", "e", "f"} },
            {'4', new () {"g", "h", "i"} },
            {'5', new () {"j", "k", "l"} },
            {'6', new () {"m", "n", "o"} },
            {'7', new () {"p", "q", "r", "s"}},
            {'8', new () {"t", "u", "v"}},
            {'9', new () {"w", "x", "y", "z"} }
        };

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();

            var rslt = new List<string>();
            StringBuilder sb = new();
            LinkData root = null;
            LinkData linkData = null;

            var digistArray = digits.ToArray();

            for (var i = 0; i < digistArray.Length; i++)
            {
                linkData = new() { Data = map[digistArray[i]] };

                if (root == null)
                {
                    root = linkData;
                    continue;
                }

                root.Append(linkData);
            }

            Caculate(root);

            return Rslt;
        }

        private void Caculate(LinkData linkData, string value = "")
        {
            string rsltValue = string.Empty;

            for (var i = 0; i < linkData.Data.Count(); i++)
            {
                rsltValue = value + linkData.Data[i];

                if (linkData.HasNext)
                {
                    Caculate(linkData.Next, rsltValue);
                }
                else
                {
                    Rslt.Add(rsltValue);
                }
            }
        }

        internal class LinkData
        {
            private LinkData next;
            public List<string> Data { get; set; }

            public LinkData Next
            {
                get => next;
                set
                {
                    next = value;
                    HasNext = true;
                }
            }

            public bool HasNext { get; private set; }

            public void Append(LinkData linkData)
            {
                if (HasNext)
                    Next.Append(linkData);
                else
                    Next = linkData;
            }
        }
    }
}