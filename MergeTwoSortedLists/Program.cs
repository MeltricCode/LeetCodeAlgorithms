using MergeTwoSortedLists.Algorithm;

// Problem url: https://leetcode.com/problems/merge-two-sorted-lists/

Sorter sorter = new();

var l1 = new ListNode(1);
var l2 = new ListNode(2);
var l3 = new ListNode(4);

l1.next = l2;
l2.next = l3;

var l11 = new ListNode(1);
var l22 = new ListNode(3);
var l33 = new ListNode(5);

l11.next = l22;
l22.next = l33;

Console.WriteLine(sorter.MergeTwoLists(l1, l11));