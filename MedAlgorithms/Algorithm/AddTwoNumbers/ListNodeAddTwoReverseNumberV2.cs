﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedAlgorithms.Algorithm.AddTwoNumbers
{
    //Problem url: https://leetcode.com/problems/add-two-numbers

    public class ListNodeAddTwoReverseNumberV2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) //the performance is 26ms
        {
            Stack<int> l1Stack = new();
            Stack<int> l2Stack = new();
            while (l1 != null)
            {
                l1Stack.Push(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                l2Stack.Push(l2.val);
                l2 = l2.next;
            }
            StringBuilder l1Reversed = new(), l2Reversed = new();

            while (l1Stack.Count > 0)
            {
                l1Reversed.Append(l1Stack.Pop());
            }
            while (l2Stack.Count > 0)
            {
                l2Reversed.Append(l2Stack.Pop());
            }
            string result = (BigInteger.Parse(l1Reversed.ToString()) + BigInteger.Parse(l2Reversed.ToString())).ToString();
            ListNode resultNode = new();
            ListNode current = resultNode;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                current.val = Convert.ToInt32(result[i].ToString());
                if ((i - 1) >= 0)
                {
                    current.next = new ListNode();
                    current = current.next;
                }
            }
            return resultNode;
        }
    }
}
