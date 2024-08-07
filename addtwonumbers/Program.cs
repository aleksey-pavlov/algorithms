/* https://leetcode.com/problems/add-two-numbers/ */

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