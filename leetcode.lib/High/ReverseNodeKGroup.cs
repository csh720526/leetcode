using System.Collections.Generic;
using System.Linq;

namespace leetcode.lib.High
{
    public class ReverseNodeKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var node = head;
            int cnt = 0;
            ListNode lastNode = null;
            ListNode firstNode = null;
            List<ListNode> tmpNode = new();
            var stack = new Stack<ListNode>();

            while (node != null)
            {
                cnt++;
                // stack.Push(node);
                stack.Push(new ListNode(node.val));
                node = node.next;

                if (cnt % k == 0)
                {
                    while (stack.Count() > 0)
                    {
                        if (lastNode == null)
                        {
                            lastNode = stack.Pop();
                            firstNode = lastNode;
                        }
                        else
                        {
                            lastNode.next = stack.Pop();
                            lastNode = lastNode.next;
                        }
                    }
                }
            }

            while (stack.Count() > 0)
                tmpNode.Add(stack.Pop());

            for (var i = tmpNode.Count() - 1; i >= 0 ; i--)
            {
                lastNode.next = tmpNode[i];
                lastNode = lastNode.next;
            }

            return firstNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}