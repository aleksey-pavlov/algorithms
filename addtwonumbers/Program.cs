/*
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
*/

using System.Numerics;


// var list1 = new ListNode(2, new ListNode(4, new ListNode(3)));
// var list2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var list1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
var list2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

var res = AddTwoNumbers(list1, list2);

while (res != null) {
    Console.WriteLine(res.val);
    res = res.next;
}


ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
{
    ListNode? head = null;
    ListNode? current = null;
    var remainder = 0;

    while (l1 != null || l2 != null)
    {
        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + remainder;
        
        if (sum >= 10)
        {
            remainder = 1;
            sum -= 10;
        }
        else
        {
            remainder = 0;
        }
        
        if (head == null)
        {
            current = head = new ListNode(sum);
        }
        else
        {
            current = current!.next = new ListNode(sum);
        }

        l1 = l1?.next;

        l2 = l2?.next;
    }

    if (remainder > 0)
    {
        current!.next = new ListNode(remainder);
    }
    
    return head;
}


public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}