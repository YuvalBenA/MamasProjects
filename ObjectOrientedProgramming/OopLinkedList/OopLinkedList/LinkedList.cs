using System;
using System.Collections.Generic;
using System.Text;

namespace OopLinkedList
{
    class LinkedList
    {
        private Node Head { get; set; }

        public LinkedList(Node head)
        {
            Head = head;
        }

        public LinkedList()
        {
            Head = null;
        }

        public void Append(int value)
        {
            Node append = new Node(value);
            if (Head != null)
            {
                Node lastNode = Head;
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = append;
            }
            else
            {
                Head = append;
            }
        }


        public void Prepend(int value)
        {
            Node copy = Head;
            Node newHead = new Node(value, copy);
            Head = newHead;
        }

        public int Pop()
        {
            if (Head != null)
            {
                Node copyList = Head;
                Node newHead = new Node(copyList.Value);
                LinkedList listAfterChanges = new LinkedList(newHead);
                if (copyList.Next != null)
                {
                    copyList = copyList.Next;
                    if (copyList.Next != null)
                    {
                        while (copyList.Next != null)
                        {
                            listAfterChanges.Append(copyList.Value);
                            copyList = copyList.Next;
                        }
                        Head = listAfterChanges.Head;
                        return copyList.Value;
                    }
                    Head = listAfterChanges.Head;
                    return copyList.Value;
                }
                Head = null;
                return copyList.Value;
            }
            Console.WriteLine("Empty List!");
            return -1;
        }

        public int Unqueue()
        {
            if (Head != null)
            {
                Node copyList = Head;
                if (copyList.Next != null)
                {
                    int firstNodeValue = copyList.Value;
                    Node newHead = copyList.Next;
                    Head = newHead;
                    return firstNodeValue;
                }
                Head = null;
                return copyList.Value;
            }
            Console.WriteLine("Empty List!");
            return -1;
        }


        public void PrintLinkedList()
        {
            if (Head != null)
            {
                Node copyList = Head;
                while (copyList.Next != null)
                {
                    Console.WriteLine(copyList.Value);
                    copyList = copyList.Next;
                }
                Console.WriteLine(copyList.Value);
            }
            else
            {
                Console.WriteLine("Empty List.");
            }
        }

        public List<int> ToList()
        {
            Node copyList = Head;
            List<int> copyValues = new List<int>();
            if (Head != null)
            {
                while (copyList.Next != null)
                {
                    copyValues.Add(copyList.Value);
                    copyList = copyList.Next;
                }
                copyValues.Add(copyList.Value);
            }
            return copyValues;
        }

        public bool IsCircular()
        {
            if (Head != null)
            {
                Node copyList = Head;
                while (copyList.Next != null)
                {
                    if (copyList.Next == Head)
                        return true;
                    copyList = copyList.Next;
                }
                return false;
            }
            Console.WriteLine("Empty List!");
            return false;
        }

        public void Sort()
        {
            LinkedList copyList = new LinkedList(Head);
            List<int> helpSort = copyList.ToList();
            helpSort.Sort();
            Node newHead = new Node(helpSort[0]);
            LinkedList sortedList = new LinkedList(newHead);
            int countItems = 1;
            while (countItems < helpSort.Count)
            {
                sortedList.Append(helpSort[countItems]);
                countItems = countItems + 1;
            }
            Head = newHead;
        }

        public int GetMaxNode()
        {
            LinkedList copyList = new LinkedList(Head);
            List<int> sortedValues = copyList.ToList();
            sortedValues.Sort();
            return sortedValues[sortedValues.Count - 1];
        }

        public int GetMinNode()
        {
            LinkedList copyList = new LinkedList(Head);
            List<int> sortedValues = copyList.ToList();
            sortedValues.Sort();
            return sortedValues[0];
        }


    }
}
