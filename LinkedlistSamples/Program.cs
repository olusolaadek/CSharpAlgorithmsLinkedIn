public class MyLinkedlist
{

    Node head;
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            this.data = d;
        }
    }
    public void DisplayList()
    {
        Node current = head;
        while (current != null)
        {

            Console.Write(current.data + " ->");
            current = current.next;
        }
    }
    public void DeleteBackHalf()
    {
        if (head == null || head.next == null)
        {
            head = null;
        }
        Node slow = head;
        Node fast = head;
        Node prev = null;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            fast = fast.next.next;
            slow = slow.next;
        }

        prev.next = null;
    }

    public void DeleteKthElementFromEnd(int k)
    {
        if (head == null || k == 0)
        {
            return;
        }

        Node first = head;
        Node second = head;

        for (int i = 0; i < k; i++)
        {

            if (second.next == null)
            {
                // k >= length of list
                if (i == k - 1)
                {
                    head = head.next;
                }
                return;
            }
            second = second.next!;
        }
        while (second.next != null)
        {
            first = first.next;
            second = second.next;
        }

        first.next = first.next.next;


    }
    public static void Main()
    {
        Node firstNode = new Node(3);
        Node secondNode = new Node(4);
        Node thirdNode = new Node(5);
        Node fourthNode = new Node(6);
        Node fifthNode = new Node(7);
        Node sixthNode = new Node(8);


        MyLinkedlist listy = new MyLinkedlist();
        listy.head = firstNode;
        firstNode.next = secondNode;
        secondNode.next = thirdNode;
        thirdNode.next = fourthNode;
        //fourthNode.next = fifthNode;
        //fifthNode.next = sixthNode;

        listy.DisplayList();
        // listy.DeleteBackHalf();
        listy.DeleteKthElementFromEnd(1);
        Console.WriteLine();
        listy.DisplayList();
    }
}

