using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestInit()
        {
            LinkedList ll = new LinkedList(15);
            Assert.AreEqual(ll.ToString(), "15 -> null");
        }

        [TestMethod]
        public void TestInsert()
        {
            LinkedList ll = new LinkedList(15);
            // Inserting a few variables here
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            ll.Insert(20);
            Assert.AreEqual(ll.ToString(), "20 -> 19 -> 18 -> 17 -> 16 -> 15 -> null");

            // Deleting a specific element
            //ll.Remove(21);
            //ll.Remove(18); // It should find this one and delete it
            //ll.ToString();
        }

        [TestMethod]
        public void TestDeleteHead()
        {
            LinkedList ll = new LinkedList(15);
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            ll.Insert(20);
            ll.DeleteHead();
            Assert.AreEqual(ll.ToString(), "19 -> 18 -> 17 -> 16 -> 15 -> null");
        }

        [TestMethod]
        public void TestDeleteTail()
        {
            LinkedList ll = new LinkedList(15);
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            ll.DeleteTail();
            Assert.AreEqual(ll.ToString(), "19 -> 18 -> 17 -> 16 -> null");
        }

        [TestMethod]
        public void TestContains()
        {
            LinkedList ll = new LinkedList(15);
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            Assert.AreEqual(ll.Contains(17), true);
            Assert.AreEqual(ll.Contains(3), false);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void TestRemoveException()
        {
            LinkedList ll = new LinkedList(15);
            // Inserting a few variables
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            ll.Insert(20);

            // should thow exception here because it's not in the linked list
            ll.Remove(21);
        }

        [TestMethod]
        public void TestRemove()
        {
            LinkedList ll = new LinkedList(15);
            // Inserting a few variables
            ll.Insert(16);
            ll.Insert(17);
            ll.Insert(18);
            ll.Insert(19);
            ll.Insert(20);

            ll.Remove(18);
            Assert.AreEqual(ll.ToString(), "20 -> 19 -> 17 -> 16 -> 15 -> null");
        }
    }
}
