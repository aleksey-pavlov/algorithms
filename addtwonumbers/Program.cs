/* https://leetcode.com/problems/add-two-numbers/ */

using System.Diagnostics;
using Addtwonumbers;


var sol = new Solution();

var list1 = new ListNode(2, new ListNode(4, new ListNode(3)));
var list2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var res = sol.AddTwoNumbers(list1, list2);

while (res != null) {
    Console.WriteLine(res.val);
    res = res.next;
}