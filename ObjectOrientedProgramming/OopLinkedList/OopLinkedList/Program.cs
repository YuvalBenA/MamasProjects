using System;

namespace OopLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node t = new Node(10);
            Node t2 = new Node(9, t);
            Node t3 = new Node(8, t2);
            Node t4 = new Node(7, t3);
            LinkedList test = new LinkedList(t4);
            test.Append(11);
            test.Prepend(6);
            Console.WriteLine(test.Pop());
            Console.WriteLine(" ");
            test.PrintList();
        }
    }
}
