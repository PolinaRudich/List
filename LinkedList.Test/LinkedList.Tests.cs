using NUnit.Framework;
using System;



namespace LList.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 })]
        public void LinkedAddFirstTest(int[] array, int val, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.AddFirst(val);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 2 })]
        public void RemoveAt(int[] array, int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveAt(index);
            int[] actual = linkedList.ToArray();

            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] {1},3,7)]
        public void SetNegativeTest(int[] array,int idx, int val)
        {
            LinkedList linkedList = new LinkedList(array);
            
            Assert.Throws(typeof(IndexOutOfRangeException), () => linkedList.Set(idx,val));

        }
        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        public void L(int[] array, int val, int[] expectedArray)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.AddLast(val);
            int[] arrayLink = linkedList.ToArray();


            Assert.AreEqual(expectedArray, arrayLink);
        }



        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { }, 0)]
        public void GetLengthTest(int[] array, int expected)
        {
            LinkedList arrayList = new LinkedList(array);
            int actual = arrayList.GetLength();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        public void AddFirst2(int[] array, int[] list, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList linkedList1 = new LinkedList(list);
            linkedList.AddLast(linkedList1);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);
        }
        //[TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]

        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        public void AddFirst(int[] array, int[] list, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList linkedList1 = new LinkedList(list);
            linkedList.AddFirst(linkedList1);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] {})]
        public void RemoveLast(int[] array, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveLast();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);

        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        public void RemoveFirst(int[] array, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveFirst();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 5, new int[] { 1, 5, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 5, new int[] {5, 1, 2, 3, 4 })]
        public void AddAtTest(int[] array, int idx, int val, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.AddAt(idx, val);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 1, 2 }, new int[] { 1, 1,2, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 5 }, new int[] { 1,5, 1, 2, 3, 4 })]
        public void AddAt(int[] array, int idx, int[]list, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList list1 = new LinkedList(list);
            linkedList.AddAt(idx, list1);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 2, 4 }, 2, 1, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 2, 4 }, 1, 0, new int[] { 2, 2, 4 })]
        [TestCase(new int[] { 1, 1, 1, 9, 9, 2, 3, 4 }, 9, 3, new int[] { 1, 1, 1, 9, 2, 3, 4 })]
            [TestCase(new int[] { 1,1,1,1,1, 2, 2, 4 }, 1, 0, new int[] { 1, 1, 1, 1, 2, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4,3, new int[] { 1, 2, 3, 5, 6 })]
        public void RemoveFirstTest(int[] array, int val, int index, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);


            int idx = linkedList.RemoveFirst(val);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(index, idx);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3 }, 1)]
        public void GetFirst(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.GetFirst();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        public void GetLast(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.GetLast();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { })]
        public void GetFirstNegativeTest(int[] array)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws(typeof(NullReferenceException), () => linkedList.GetFirst());
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 2)]
        public void Get(int[] array, int idx, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.Get(idx);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, 2)]
        public void GetNegative(int[] array, int idx)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws(typeof(NullReferenceException), () => linkedList.Get(idx));
        }
        [TestCase(new int[] { 1, 2, 2, 2, 22, 4, 5, 6, 7 }, 22)]
        [TestCase(new int[] { 0, 2, 2, 2, 22, 4, 5, 6, 76 }, 76)]
        [TestCase(new int[] { 999, 2, -1, 2, 22, 4, 5, 6, 7 }, 999)]
        [TestCase(new int[] { -999, -2, -1, -2, -22, -4, -5, -6, -7 }, -1)]
        public void MaxTes(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.Max();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 2, 2, 22, 4, 5, 6, 7 }, 1)]
        [TestCase(new int[] { 0, 2, 2, 2, 22, 4, 5, 6, 76 }, 0)]
        [TestCase(new int[] { 999, 2, -1, 2, 22, 4, 5, 6, 7 }, -1)]
        [TestCase(new int[] { -1, -2, -2, -2, -22, -4, -5, -6, -76 }, -76)]

        public void MinTes(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.Min();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 2, 2, 22, 4, 5, 6, 7 }, 4)]
        [TestCase(new int[] { 0, 2, 2, 2, 22, 4, 5, 23, 76 }, 8)]
        [TestCase(new int[] { 999, 2, -1, 2, 22, 4, 5, 6, 7 }, 0)]
        [TestCase(new int[] { -1, 0, -2, -2, -22, -4, -5, -6, -76 }, 1)]

        public void IndexOfMax(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.IndexOfMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, new int[] { 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void RemoveFirstMultiple(int[] array, int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveFirstMultiple(n);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void RemoveLastMultiple(int[] array, int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveLastMultiple(n);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1, 3, new int[] { 1, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 3, new int[] { 4, 5, 6 })]
        public void RemoveAtMultiple(int[] array, int idx, int n, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveAtMultiple(idx, n);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 2, 4, 2, 6 }, 2, new int[] { 1, 4, 6 })]
        [TestCase(new int[] { 1, 1, 1, 1, 5, 6 }, 1, new int[] { 5, 6 })]
        [TestCase(new int[] { 1, 1, 1, 1, 5, 6 }, 1111, new int[] { 1, 1, 1, 1, 5, 6 })]
        public void RemoveAll(int[] array, int val, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveAll(val);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 44, false)]
        public void Contains(int[] array, int val, bool expected)
        {
            LinkedList linkedList = new LinkedList(array);

            bool actual = linkedList.Contains(val);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 2, 4, 5 }, 2, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 44, -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 4)]
        public void IndexOf(int[] array, int val, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.IndexOf(val);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 0 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, -6, 0 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, -85, -6, 0 }, 4)]
        [TestCase(new int[] { -1000, 2, 3, 4, -85, -6, 0 }, 0)]
        public void IndexOfMin(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 2, 0, -9999, 6, 7, 2 }, new int[] { -9999, 0, 2, 2, 3, 6, 7 })]
        public void SortTests(int[] array, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.Sort();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 2, 0, -9999, 6, 7, 2 }, new int[] { 7, 6, 3, 2, 2, 0, -9999 })]
        public void SortDesc(int[] array, int[] expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.SortDesc();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {1,2,3,4,5}, new int[] {5,4,3,2,1})]
        [TestCase(new int[] {  }, new int[] {  })]
        [TestCase(new int[] {1 }, new int[] { 1})]
        [TestCase(new int[] { 1,2,3,4}, new int[] {4,3,2,1 })]
        public void ReverseTest(int[]array, int[]expected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.Reversee();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}