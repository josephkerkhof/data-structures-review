using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Welcome to my data structures review project.");

            //p.RunTheLinkedList();
            p.RunTheDoublyLinkedList();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey(true);
        }

        private void RunTheDoublyLinkedList()
        {
            DoublyLinkedList dll = new DoublyLinkedList(1);
            // Inserting a few variables
            dll.Insert(4);
            dll.Insert(2);
            dll.Insert(17);
            dll.ToString();
            dll.Insert(3);
            dll.ToString();
        }

        private void RunTheLinkedList()
        {
            LinkedList ll = new LinkedList(15);
            // Inserting a few variables here
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            ll.Insert(20);
            ll.ToString();

            // Deleting the head
            ll.DeleteHead();
            ll.ToString();

            // Deleting the tail
            ll.DeleteTail();
            ll.ToString();

            // Deleting a specific element
            ll.Remove(21); // Should say it wasn't found
            ll.Remove(18); // It should find this one and delete it
            ll.ToString();

            Console.WriteLine("Does the linked list contain 17? " + ll.Contains(17)); // Should return true
            Console.WriteLine("Does the linked list contain 3? " + ll.Contains(3)); // Should return false
        }
    }
}
