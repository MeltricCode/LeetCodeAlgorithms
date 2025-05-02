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
        public ListNode Clone()
        {
            ListNode dummy = new();
            ListNode current = dummy;
            ListNode source = this;

            while (source != null)
            {
                current.next = new(source.val);
                current = current.next;
                source = source.next;
            }
            return dummy.next;
        }
        public override string ToString()
        {
            ListNode clone = Clone();
            string str = "[";
            str += clone.val + ",";
            while (clone.next != null)
            {
                str += clone.next.val + ",";
                clone.next = clone.next.next;
            }
            str = str.Remove(str.Length - 1);
            str += "]";
            return str;
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
                if (list1.val == list2.val)
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
