using NUnit.Framework;
using System;

namespace DList.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] {}, 4, new int[] { 4 })]
        public void AddLast(int[] array, int val, int[] expected)
        {
            DoublyLinkedList doubleLinkedList = new DoublyLinkedList(array);
            doubleLinkedList.AddLast(val);
            int[] actual = doubleLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        public void AddFirst(int[] array, int val, int[] expected)
        {
            DoublyLinkedList doubleLinkedList = new DoublyLinkedList(array);
            doubleLinkedList.AddFirst(val);
            int[] actual = doubleLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 2, 3 })]
        public void RemoveAtTest(int[] array, int idx, int[] expected)
        {
            DoublyLinkedList doubleLinkedList = new DoublyLinkedList(array);
            doubleLinkedList.RemoveAt(idx);
            int[] actual = doubleLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 10)]
        public void RemoveAtNegativeTest (int[]array,int idx)
        {
            DoublyLinkedList doubleLinkedList = new DoublyLinkedList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => doubleLinkedList.RemoveAt(idx));
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        public void AddLast(int[] array, int[] list, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            DoublyLinkedList linkedList1 = new DoublyLinkedList(list);
            linkedList.AddLast(linkedList1);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]

        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        public void AddFirstList(int[] array, int[] list, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            DoublyLinkedList linkedList1 = new DoublyLinkedList(list);
            linkedList.AddFirst(linkedList1);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3,4,5,6 }, new int[] { 1, 2,3,4,5 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveLast(int[] array, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            linkedList.RemoveLast();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);

        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirst(int[] array, int[] expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            doublyLinkedList.RemoveFirst();
            int[] actual = doublyLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { })]
        public void RemoveFirstNegativeFirst(int[] array)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            Assert.Throws(typeof(Exception), () => doublyLinkedList.RemoveFirst());
        }
        [TestCase(new int[] { })]
        public void RemoveLastNegativeFirst(int[] array)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            Assert.Throws(typeof(Exception), () => doublyLinkedList.RemoveLast());
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 9, new int[] { 1, 9, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 9, new int[] { 9,1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 9, new int[] { 1, 2, 3, 9,4 })]
        public void AddAtTest(int[] array, int idx, int val, int[] expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            doublyLinkedList.AddAt(idx, val);
            int[] actual = doublyLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        public void GetFirst(int[] array, int expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            int actual = doublyLinkedList.GetFirst();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 1)]
        public void GetTest(int[] array, int idx, int expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            int actual = doublyLinkedList.Get(idx);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 9)]
        public void GetNegativeTest(int[] array, int idx)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => doublyLinkedList.Get(idx));
        }
        [TestCase(new int[] { }, 9)]
        public void GetNegativeSecondTest(int[] array, int idx)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => doublyLinkedList.Get(idx));
        }
        [TestCase(new int[] { 1, 2, 2, 4 }, 2, 1, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 2, 4 }, 1, 0, new int[] { 2, 2, 4 })]
        [TestCase(new int[] { 1, 1, 1, 9, 9, 2, 3, 4 }, 9, 3, new int[] { 1, 1, 1, 9, 2, 3, 4 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 2, 2, 4 }, 1, 0, new int[] { 1, 1, 1, 1, 2, 2, 4 })]
        public void RemoveFirstTest(int[] array, int val, int index, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);


            int idx = linkedList.RemoveFirst(val);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(index, idx);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 9, 8, 7, 3, 4, 5, 44, 4, 4 }, 44)]
        public void MaxTest(int[] array, int expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            int actual = doublyLinkedList.Max();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 8, 7, 3, 4, 5, 44, 4, 4 }, 3)]
        public void MinTest(int[] array, int expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            int actual = doublyLinkedList.Min();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 5, 66, 4, 7, 8, 3, 9, 0 }, 2)]
        [TestCase(new int[] { 1, 2, 2, 2, 22, 4, 5, 6, 7 }, 4)]
        [TestCase(new int[] { 0, 2, 2, 2, 22, 4, 5, 23, 76 }, 8)]
        [TestCase(new int[] { 999, 2, -1, 2, 22, 4, 5, 6, 7 }, 0)]
        [TestCase(new int[] { -1, 0, -2, -2, -22, -4, -5, -6, -76 }, 1)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            int actual = doublyLinkedList.IndexOfMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, new int[] { 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 7, 8 }, 1, new int[] { 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5, new int[] { 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4, new int[] { 5,6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new int[] { })]
        public void RemoveFirstMultiplyTest(int[] array, int n, int[] expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            doublyLinkedList.RemoveFirstMultiple(n);
            int[] actual = doublyLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 7, 8 }, 1, new int[] { 7 })]
        public void RemoveLastMultiplyTest(int[] array, int n, int[] expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            doublyLinkedList.RemoveLastMultiply(n);
            int[] actual = doublyLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 2, new int[]{1, 2, 5, 6})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 3, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 5, 1, new int[] { 1,2,3,4, 5 })]
        public void RemoveAtMultiple(int[]array, int idx, int n, int[]expected)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(array);
            doublyLinkedList.RemoveAtMultiple(idx, n);
            int[] actual = doublyLinkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 2, 4, 2, 6 }, 2, new int[] { 1, 4, 6 })]
        [TestCase(new int[] { 1, 1, 1, 1, 5, 6 }, 1, new int[] { 5, 6 })]
        [TestCase(new int[] { 1, 1, 1, 1, 5, 6 }, 1111, new int[] { 1, 1, 1, 1, 5, 6 })]
        public void RemoveAll(int[] array, int val, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            linkedList.RemoveAll(val);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 44, false)]
        public void Contains(int[] array, int val, bool expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);

            bool actual = linkedList.Contains(val);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 2, 4, 5 }, 2, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 44, -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 4)]
        public void IndexOf(int[] array, int val, int expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);

            int actual = linkedList.IndexOf(val);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 0 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -6, 0 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, -85, -6, 0 }, 4)]
        [TestCase(new int[] { -1000, 2, 3, 4, -85, -6, 0 }, 0)]
        public void IndexOfMin(int[] array, int expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            int actual = linkedList.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        public void ReverseTest(int[] array, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            linkedList.Reversee();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 2, 0, -9999, 6, 7, 2 }, new int[] { -9999, 0, 2, 2, 3, 6, 7 })]
        public void SortTests(int[] array, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            linkedList.Sort();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 2, 0, -9999, 6, 7, 2 }, new int[] { 7, 6, 3, 2, 2, 0, -9999 })]
        public void SortDesc(int[] array, int[] expected)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList(array);
            linkedList.SortDesc();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}