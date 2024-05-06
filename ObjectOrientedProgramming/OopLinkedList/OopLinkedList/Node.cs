using System;
using System.Collections.Generic;
using System.Text;

namespace OopLinkedList
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            Value = default;
            Next = null;
        }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }

    }
}
