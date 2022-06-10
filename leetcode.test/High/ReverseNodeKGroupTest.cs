using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leetcode.lib.High;
using Xunit;

namespace leetcode.test.High
{
    public class ReverseNodeKGroupTest
    {
        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
                3
            },
            new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(5)))))),
                3
            }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test1(ListNode head, int k)
        {
            var obj = new ReverseNodeKGroup();

            var rslt = obj.ReverseKGroup(head, k);
        }
    }
}