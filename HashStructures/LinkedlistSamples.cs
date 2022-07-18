using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashStructures
{
    internal class LinkedlistSamples
    {

        public Node head;
        public bool HasCycle()
        {
            HashSet<Node> cycle = new HashSet<Node>();

            Node current = head;
            while (current != null)
            {
                if (cycle.Contains(current))
                {
                    return true;
                }
                cycle.Add(current);
                current = current.next;
            }
            return false;
        }
    }


    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
