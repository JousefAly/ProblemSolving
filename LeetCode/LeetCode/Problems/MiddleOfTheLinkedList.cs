using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{


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

    public class MiddleOfTheLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {

            var fastPointer = head;

            //when fast pointer reaches the end of the linked list this means 
            // slow pointer is at the middle of the linked list
            if (head != null)
            {
                while (fastPointer != null && fastPointer.next != null)
                {
                    fastPointer = fastPointer.next.next;
                    head = head.next;
                }
            }
            return head;
        }

        public static LinkedList<int> PrintFromNode(LinkedListNode<int> node)
        {
            //var text = new StringBuilder("[ ");
            var linkedList = new LinkedList<int>();
            if (node != null)
            {
                while (node.Next != null)
                {
                    linkedList.AddLast(node.Value);
                    node = node.Next;
                }
            }
            return linkedList;
        }

        public static void Run()
        {
           //nothing here
        }
    }
}
