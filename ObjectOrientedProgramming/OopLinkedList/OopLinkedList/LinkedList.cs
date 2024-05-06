﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OopLinkedList
{
    class LinkedList
    {
        private Node Head { get; set; }


        public LinkedList()
        {
            Head = new Node();
        }
        public LinkedList(Node head)
        {
            Head = head;
        }

        public void Append(int value)
        {
            Node append = new Node(value);
            Node lastNode = GetLastNode();
            lastNode.Next = append;
        }

        public Node GetLastNode()
        {
            Node copy = Head;
            while (copy.Next != null)
            {
                copy = copy.Next;
            }
            return copy;
        }
        
        public void Prepend(int value)
        {
            Node copy = Head;
            Node newHead = new Node(value, copy);
            Head = newHead;
        }

        public int Pop()
        {
            Node copy = Head;
            LinkedList cop = new LinkedList();
            cop.Head.Value = copy.Value;
            if (copy.Next != null)
            {
                copy = copy.Next;
                if (copy.Next != null)
                {
                    while (copy.Next.Next != null)
                    {
                        cop.Append(copy.Value);
                        copy = copy.Next;
                    }
                    cop.Append(copy.Value);
                    Head = cop.Head;
                    return copy.Next.Value;
                }
                else
                {
                    Head = cop.Head;
                    return copy.Value;
                }
            }
            else
            {
                Head = new Node();
                return copy.Value;
            }
        }

        public void PrintList()
        {
            Node copy = Head;
            while (copy.Next !=null)
            {
                Console.WriteLine(copy.Value);
                copy = copy.Next;
            }
            Console.WriteLine(copy.Value);
        }
    }
}
