using System;

public class LinkedList
{
    private class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            next = null;
        }
    }

    Node head;
	public LinkedList(int value)
	{
        head = new Node(value);
	}

    public void Insert(int value)
    {
        Node insertMe = new Node(value);
        insertMe.next = head;
        head = insertMe;
    }

    public void DeleteHead()
    {
        if(head.next != null)
        {
            head = head.next;
        }
    }

    public void DeleteTail()
    {
        Node current = head;
        while(current.next.next != null)
        {
            current = current.next;
        }
        current.next = null; // Iterate thru the linked list
    }

    public void Remove(int value)
    {
        if(head.value == value)
        {
            DeleteHead();
            return;
        }

        Node current = head;
        while(current.next != null)
        {
            if(current.next.value == value)
            {
                current.next = current.next.next;
                return;
            }
            current = current.next; // Iterate thru the linked list
        }
        Console.WriteLine($"{value} was not found in the linked list.");
    }

    public bool Contains(int value)
    {
        Node current = head;
        while(current.next != null)
        {
            if(current.value == value)
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public void ToString()
    {
        Node current = head;
        while(current != null)
        {
            Console.Write($"{current.value} -> ");
            current = current.next;
        }
        Console.Write("null\n");
    }
}
