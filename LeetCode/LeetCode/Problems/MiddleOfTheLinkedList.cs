using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MiddleOfTheLinkedList
    {
        public static LinkedListNode<int> MiddleNode(LinkedListNode<int> head)
        {
            var nodeIndex = (int)Math.Round((double)head.List.Count - 1 / 2);
            //var node = head.List.ElementAt(nodeIndex);
            var node = head.List;
        }
    }
}
