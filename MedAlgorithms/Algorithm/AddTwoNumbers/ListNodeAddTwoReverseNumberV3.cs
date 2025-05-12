using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedAlgorithms.Algorithm.AddTwoNumbers
{
    //Problem url: https://leetcode.com/problems/add-two-numbers

    public class ListNodeAddTwoReverseNumberV3
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) //the performance is 1ms
        {
            ListNode dummy = new();
            ListNode current = dummy;
            int carry = 0;
            while(l1 != null || l2 != null || carry > 0)
            {
                int sum = carry;
                if(l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                current.next = new(sum % 10);
                current = current.next;
                carry = sum / 10;
            }
            return dummy.next;
        }
    }
}
