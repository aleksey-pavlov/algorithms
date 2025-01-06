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


var list1 = new ListNode(2, new ListNode(4, new ListNode(3)));
var list2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var res = AddTwoNumbers(list1, list2);

while (res != null) {
    Console.WriteLine(res.val);
    res = res.next;
}


ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var num1 = "";
    var num2 = "";

    while (l1 != null || l2 != null)
    {
        if (l1 != null)
        {
            num1 = l1.val + num1;
            l1 = l1.next;
        }

        if (l2 != null)
        {
            num2 = l2.val + num2;
            l2 = l2.next;
        }
    }

    var res = BigInteger.Parse(num1) + BigInteger.Parse(num2);

    ListNode list = null;
    foreach (var i in res.ToString())
    {
        list = new ListNode(int.Parse(i.ToString()), list);
    }

    return list;
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