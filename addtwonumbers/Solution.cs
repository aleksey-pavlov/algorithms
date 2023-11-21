using System;
using System.Collections.Generic;
using System.Linq;

namespace Addtwonumbers
{
    /**
     * Definition for singly-linked list.
     **/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            
            var num1 = ListToReversedInt(l1);
            var num2 = ListToReversedInt(l2);
           
            var res = num1 + num2;

            var list = IntToReverseList(res);

            return list;
        }

        public int ListToReversedInt(ListNode l) {
            
            var num = new List<string>();

            while (l != null) {
                num.Add(l.val.ToString());
                l = l.next;
            }
            
            num.Reverse();

            return int.Parse(string.Join("", num));

        }

        public ListNode IntToReverseList(int num) {

            var arr = num.ToString().ToArray();

            ListNode list = null;
            for(var i = arr.Length-1; i >= 0; i--) {

                var n = arr[i];
                list = new ListNode(int.Parse(n.ToString()), list);

            }

            return list;
        }
    }
}