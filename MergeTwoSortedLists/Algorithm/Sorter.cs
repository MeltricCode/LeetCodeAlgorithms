using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists.Algorithm
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

    public class Sorter
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) // the performance is 0ms
        {
            ListNode dummy = new();
            ListNode current = dummy;
            while (list1 != null && list2 != null)
            {
                if(list1.val == list2.val)
                {
                    current.next = new(list1.val);
                    current = current.next;
                    current.next = new(list2.val);
                    current = current.next;
                    list1 = list1.next;
                    list2 = list2.next;
                }
                else if (list1.val > list2.val)
                {
                    current.next = new(list2.val);
                    current = current.next;
                    list2 = list2.next;
                }
                else
                {
                    current.next = new(list1.val);
                    current = current.next;
                    list1 = list1.next;
                }
            }

            current.next = list1 == null ? list2 : list1;
            return dummy.next;
        }
    }
}
