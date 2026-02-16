
// Input: head = [1,2,3,4,5,6]
// Output: [4,5,6]


var ll = new ListNode(1,  new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));

Console.WriteLine("Method 1 - via list");
var middle = MiddleNode(ll);
while (middle != null)
{
    Console.WriteLine(middle.val);
    middle = middle.next;
}

Console.WriteLine("Method 2 - via two iterators");
var middle2 = MiddleNode2(ll);
while (middle2 != null)
{
    Console.WriteLine(middle2.val);
    middle2 = middle2.next;
}

// Method 1
ListNode MiddleNode(ListNode head) {
        
    var ll = new List<ListNode>();
    while (head != null) {
        ll.Add(head);
        head = head.next;
    }

    return ll[ll.Count / 2];
}

// Method 2
ListNode MiddleNode2(ListNode head) {
    var current = head;
    var seeker = head;
    while (seeker != null && seeker.next != null) {
        current = current.next;
        seeker = seeker.next.next;
    }

    return current;
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}