using System;

namespace OopLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node t = new Node(10);
            Node t2 = new Node(9, t);

            LinkedList test = new LinkedList(t);
            Console.WriteLine(test.Pop());
            Console.WriteLine(" ");
            test.PrintList();
        }
    }
}
