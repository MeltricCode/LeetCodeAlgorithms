using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.MergeTwoSortedLists
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
    }
}
