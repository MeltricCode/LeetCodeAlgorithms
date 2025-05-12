using MedAlgorithms.Algorithm.AddTwoNumbers;

ListNode l1 = new(2);
ListNode l12 = new(4);
ListNode l13 = new(3);
l1.next = l12;
l1.next.next = l13;

ListNode l2 = new(5);
ListNode l22 = new(6);
ListNode l23 = new(4);
l2.next = l22;
l2.next.next = l23;

Console.WriteLine(ListNodeAddTwoReverseNumberV3.AddTwoNumbers(l1, l2));