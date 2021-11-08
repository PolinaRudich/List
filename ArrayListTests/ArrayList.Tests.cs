using NUnit.Framework;
using List;
using System;

namespace ArrayListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[3] { 1, 2, 3 }, 4, new int[4] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 4, new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 4 })]
        public void AddLastTest(int[] array, int value, int[] expected)
        {

            ArrayList arrayList = new ArrayList(array);
            arrayList.AddLast(value);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[4] { 1, 2, 3, 4 }, 4, new int[5] { 4, 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 }, 4, new int[] { 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 })]
        public void AddFirstTest(int[] array, int value, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.AddFirst(value);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[6] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[3] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5, 6 }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5, 6 })]
        [TestCase(new int[] { 4, 5, 6 }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void AddFirstTest(int[] array, int[] list, int[] newArray)
        {
            ArrayList arrayList = new ArrayList(array);
            ArrayList arrayList1 = new ArrayList(list);
            arrayList.AddFirst(arrayList1);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(newArray, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 10 }, new int[] { 1, 2, 3, 10 })]
        [TestCase(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 4, 5, 6 })]
        public void AddLastTest(int[] array, int[] list, int[] newArray)
        {
            //arrange
            ArrayList arrayList = new ArrayList(array);
            ArrayList arrayList1 = new ArrayList(list);

            //act
            arrayList.AddLast(arrayList1);
            int[] actual = arrayList.ToArray();

            //assert
            Assert.AreEqual(newArray, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, new int[2] { 4, 5 }, new int[] { 1, 2, 4, 5, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[3] { 1, 2, 3 }, 2, new int[2] { 4, 5 }, new int[5] { 1, 2, 4, 5, 3 })]
        [TestCase(new int[3] { 1, 2, 3 }, 0, new int[2] { 4, 5 }, new int[5] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[3] { 1, 2, 3 }, 0, new int[] { }, new int[] { 1, 2, 3 })]
        public void AddAtTest(int[] array, int idx, int[] array1, int[] forExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            ArrayList arrayList1 = new ArrayList(array1);
            ArrayList expected = new ArrayList(forExpected);

            arrayList.AddAt(idx, arrayList1);

            int[] actual = arrayList.ToArray();

            Assert.AreEqual(forExpected, actual);
        }
        [TestCase(2, 5, new int[4] { 1, 2, 3, 4 }, new int[5] { 1, 2, 5, 3, 4 })]
        [TestCase(0, 5, new int[4] { 1, 2, 3, 4 }, new int[5] {5, 1, 2, 3, 4 })]
        [TestCase(1, 4, new int[3] { 1, 2, 3 }, new int[4] { 1, 4, 2, 3 })]
        [TestCase(11, 4, new int[] { 1, 2, 3,4,5,6,7,8,9,10,11,12}, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,4,12})]
        
        public void AddAtT(int idx, int val, int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);

            arrayList.AddAt(idx, val);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 4, new int[] { }, new int[] { 4 })]
        public void AddAtNegativeTest(int idx, int val, int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayList.AddAt(0,4));
        }

        [TestCase(new int[3] { 1, 2, 3 }, new int[2] { 2, 3 })]
        
        public void RemoveFirstTest(int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveFirst();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {  })]
        public void RemoveFirstNegativeTest(int[] array)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayList.RemoveFirst());
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveLast();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveLastNegativeTest(int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws(typeof(Exception), () => arrayList.RemoveLast());
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 2, 3 })]
        public void RemoveAtTest(int[] array, int idx, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveAt(idx);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(new int[] { 1, 2, 3 }, 10)]
        public void RemoveAtNegativeTest(int[] array, int idx)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws(typeof(Exception), () => arrayList.RemoveAt(idx));
        }
        [TestCase(new int[] { 5, 4, 3 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 0, 0, 4, 3 }, new int[] { 0, 0, 3, 4 })]
        [TestCase(new int[] { -1,-2,0, 0, 4, 3 }, new int[] {-2,-1, 0, 0, 3, 4 })]
        public void SortTest(int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Sort();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 4, 3 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 0, 0, 4, 3 }, new int[] { 0, 0, 3, 4 })]
        public void SortDescTest(int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.SortDesc();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 4, 3 }, 5)]
        [TestCase(new int[] { 6666666, 5, 6, 66666, 6666, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 4, 3 }, 6666666)]
        [TestCase(new int[] { 5, 4, 3 }, 5)]
        [TestCase(new int[] { 5, 4, 3 }, 5)]
        public void GetFirstTest(int[] array, int idx)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.GetFirst();
            int actual = arrayList.GetFirst();
            Assert.AreEqual(idx, actual);
        }
        [TestCase(new int[] { 5, 4, 3, 7, 7, 7, 7, 7, 7, 7, 3 }, 3)]
        public void GetLastTest(int[] array, int idx)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.GetLast();
            int actual = arrayList.GetLast();
            Assert.AreEqual(idx, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6, new int[] {})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, new int[] { 1, 2, 3, 4, 5, 6 })]
       
        public void RemoveFirstMultipleTest(int[] array, int n, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveFirstMultiple(n);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6, new int[] { })]

        public void RemoveLastMultipleTest(int[] array, int n, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveLastMultiple(n);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 10)]
        public void RemoveLastMultipleNegativeTest(int[] array, int n)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayList.RemoveLastMultiple(n));
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 1, 2, new int[] { 1, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 1, new int[] { 2, 3, 4, 5, 6 })]
        public void RemoveAtMultipleTest(int[] array, int idx, int n, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveAtMultiple(idx, n);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 2, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1,3, 2, 3, 4 }, 3, 1, new int[] { 1, 2,3, 4 })]
        public void RemoveFirst(int[] array, int val, int index, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int idx = arrayList.RemoveFirst(val);

            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(index, idx);

        }
        [TestCase(new int[] { }, 3, 1)]
        public void RemoveFirstNegative(int[] array, int val, int idx)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayList.RemoveFirst(val));
        }

            [TestCase(new int[] { 1, 2, 2, 4 }, 2, 2, new int[] { 1, 4 })]
        [TestCase(new int[] { }, 2, 0, new int[] { })]
        public void RemoveAllTest(int[] array, int val, int expectedSummery, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            int summery = arrayList.RemoveAll(val);

            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedSummery, summery);

        }
        [TestCase(new int[] { 1, 2, 2, 4 }, 4, true)]
        [TestCase(new int[] { 1, 2, 2 }, 4, false)]
        [TestCase(new int[] { }, 4, false)]
        public void ContainsTest(int[] array, int val, bool expected)
        {
            ArrayList arrayList = new ArrayList(array);
            bool actual = arrayList.Contains(val);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 2, 3, 4, 7, 5 }, 2)]

        public void MinTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            arrayList.Min();
            int actual = arrayList.Min();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void MaxTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Max();
            int actual = arrayList.Max();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        
        public void ReserveTest(int[] array, int[] expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Reverse();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 3, 9, 4 }, 2)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.IndexOfMax();
            int actual = arrayList.IndexOfMax();


            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 1)]
        [TestCase(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 0)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.IndexOfMin();
            int actual = arrayList.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 1, 4)]
        public void GetTest(int[] array, int idx, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Get(1);
            int actual = arrayList.Get(1);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 9, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 2, 5)]
        [TestCase(new int[] { 9, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, -1, 8)]
        public void GetIndexOf(int[] array, int expected, int val)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.IndexOf(val);
            int actual = arrayList.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }
    }
}