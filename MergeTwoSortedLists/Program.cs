using MergeTwoSortedLists.Algorithm;

// Problem url: https://leetcode.com/problems/merge-two-sorted-lists/

Sorter sorter = new();
(ListNode, ListNode) data = CreateTestListNodes();
ListNode result = sorter.MergeTwoLists(data.Item1, data.Item2);
Console.WriteLine($"The result is: {result}");

(ListNode, ListNode) CreateTestListNodes()
{
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

    return (l1, l11);
}
