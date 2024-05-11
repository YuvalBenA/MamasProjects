using System;
using System.Collections.Generic;
using System.Text;

namespace OopLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node t = new Node(22);
            Node t2 = new Node(9, t);
            Node t3 = new Node(17, t2);
            Node t4 = new Node(7, t3);
            LinkedList test = new LinkedList(t4);
            test.PrintLinkedList();
        }
    }
}
