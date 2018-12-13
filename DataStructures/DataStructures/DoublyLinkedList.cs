using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DoublyLinkedList
    {
        private class Node
        {
            public int value;
            public Node next;
            public Node previous;
            public Node(int value)
            {
                this.value = value;
                next = null;
                previous = null;
            }
        }

        Node head;
        public DoublyLinkedList(int value)
        {
            head = new Node(value);
        }

        public void Insert(int value)
        {
            Node insertMe = new Node(value);
            insertMe.next = head;
            head.previous = insertMe;
            head = insertMe;
        }

        public void ToString()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write($"{current.value} <-> ");
                current = current.next;
            }
            Console.Write("null\n");
        }
    }
}
