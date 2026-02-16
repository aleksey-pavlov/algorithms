
// Input - new ListNode(1, new ListNode(2));
// Output - new ListNode(2, new ListNode(1));

var reversed = ReverseList(new ListNode(1, new ListNode(2,  new ListNode(3, new ListNode(4, new ListNode(5))))));

while (reversed != null)
{
    Console.WriteLine(reversed.val);
    reversed = reversed.next;
}


ListNode ReverseList(ListNode head) {
    
    ListNode reverse = null;
    while (head != null)
    {
        ListNode temp = head.next;
        head.next = reverse;
        reverse = head;
        head = temp;
    }
    
    return reverse;
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