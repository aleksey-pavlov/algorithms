
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

            var res = int.Parse(num1) + int.Parse(num2);

            ListNode list = null;
            foreach (var i in res.ToString())
            {
                list = new ListNode(int.Parse(i.ToString()), list);
            }

            return list;
        }
    }
}