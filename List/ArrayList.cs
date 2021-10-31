using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    public class ArrayList
    {

        private int[] _array;
        //private const int _minLength = 10;
        public int Length { get; private set; }
        public ArrayList()
        {
            Length = 0;
            _array = new int[Length];
        }
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[Length];
            _array[0] = value;

        }
        public ArrayList(int[] array)
        {

            Length = array.Length;
            _array = new int[Length];

            for (int i = 0; i < Length; i++)
            {

                _array[i] = array[i];
            }

        }

        public int[] ToArray()
        {
            int[] array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                array[i] = _array[i];
            }
            return array;

        }
        public void AddLast(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

            _array[Length] = value;
            Length++;
        }
        private void UpSize()
        {


            int newLength = ( _array.Length * 3) / 2+1;
            int[] tmpArray = new int[newLength];


            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];

            }
            _array = tmpArray;



        }
        private void UpSize(int newLength)
        {



            int[] tmpArray = new int[newLength];


            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];

            }
            _array = tmpArray;



        }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        public int GetLength(int[] array)
        {
            return array.Length;
        }
        public void AddFirst(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }


            int[] tmpArray = new int[_array.Length];


            for (int i = 0; i < _array.Length - 1; i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            tmpArray[0] = value;


            _array = tmpArray;



            Length++;
            //10
            //15
            //22
            //33



            // 11   15
            // 10   10

            //while(Length<=(_array.Length/2))
            //{
            //    DownSize();
            //}
        }
        private void DownSize()
        {
            int newLenght = _array.Length * 2 / 3;
            int[] tmpArray = new int[newLenght];
            for (int i = 0; i < newLenght; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
        // 24 
        // RemoveAtMuliple(5,17)
        // 7

        // 33
        // 10

        //public override bool Equals(object obj)
        //{
        //    ArrayList arrayList = (ArrayList)obj;

        //    if (Length != arrayList.Length && !_array.Equals(arrayList._array))
        //    {
        //        return false;
        //    }
        //    return true;

        //}
        public void AddAt(int idx, int val)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            
           

            //int[] tmpArray = new int[Length];
            for (int i = Length - 1; i >= idx; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[idx] = val;
            Length++;
            if (idx > Length - 1)
            {
                throw new IndexOutOfRangeException("");
            }
        }
        
        public void AddFirst(ArrayList list)
        {
            int newLength = _array.Length + list.Length;
            int[] tmpArray = new int[newLength];
            int[] arrayList = list.ToArray();
            for (int i = 0; i < arrayList.Length; i++)
            {
                tmpArray[i] = arrayList[i];
            }

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[arrayList.Length + i] = _array[i];
            }
            _array = tmpArray;
            Length = newLength;
        }
        public void AddLast(ArrayList list)
        {
            //if (Length == _array.Length)
            //{
            //    UpSize();
            //}
            int newLength = Length + list.Length;
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }


            for (int i = 0; i < list.Length; i++)
            {
                tmpArray[Length + i] = list._array[i];
            }
            _array = tmpArray;
            Length = newLength;

        }
        public void AddAt(int idx, ArrayList list)
        {
            if(Length==0)
            {
                throw new IndexOutOfRangeException("массив пуст");
                    
            }
            UpSize(Length + list.Length);
            Array.Copy(_array, idx, _array, idx + list.Length, Length - idx);
            Array.Copy(list._array, 0, _array, idx, list.Length);

            Length = Length + list.Length;

        }
        public void RemoveFirst()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");

            }
            int[] tmpArray = new int[_array.Length - 1];
            for (int i = 0; i < _array.Length - 1; i++)
            {
                tmpArray[i] = _array[i + 1];
            }
            Length--;
            _array = tmpArray;


        }
        public void RemoveLast()
        {
            if (Length == 0)
            {
                throw new Exception("Длинна списка ноль");

            }
            int[] tmpArray = new int[_array.Length - 1];
            for (int i = 0; i < _array.Length - 1; i++)
            {
                tmpArray[i] = _array[i];
            }
            Length--;
            _array = tmpArray;
        }


        public override bool Equals(object obj)
        {
            return obj is ArrayList list &&
                  Enumerable.SequenceEqual(_array, list._array) &&
                   Length == list.Length;
        }
        public void RemoveAt(int idx)
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");

            }

            if ((idx >= 0) && (idx < Length))
            {
                for (int i = idx; i < Length - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Length--;
            }

            //Console.WriteLine(tmpArray.Length);
        }
        public void RemoveFirstMultiple(int n)
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");

            }
            if (n > 0)
            {
                int[] tmpArray = new int[_array.Length];
                for (int i = 0; i < n; i++)
                {
                    tmpArray[i] = _array[i + n];
                }
                _array = tmpArray;
                Length -= n;
            }
        }
        public int GetFirst()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");

            }
            int n = 0;
            int[] array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                array[i] = _array[i];
                n = array[0];
            }
            return n;

        }
        public int GetLast()
        {
            
            int n = 0;

            int[] array = new int[_array.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                array[i] = _array[i];
                n = array[i];
            }
            return n;

        }
        public void Sort()
        {
            int l = _array.Length;
            for (int i = 0; i < l - 1; i++)
            {
                int minValue = _array[i];
                int minIndex = i;
                for (int o = i + 1; o < Length; o++)
                {
                    if (minValue > _array[o])
                    {
                        minValue = _array[o];
                        minIndex = o;
                    }
                }

                minValue = _array[i];
                _array[i] = _array[minIndex];
                _array[minIndex] = minValue;
            }
        }
        public void SortDesc()
        {
            for (int i1 = 1; i1 < Length; i1++)
            {
                int tmp10 = _array[i1];
                int j1 = i1;
                while (j1 > 0 && tmp10 < _array[j1 - 1])
                {
                    _array[j1] = _array[j1 - 1];
                    j1--;
                }
                _array[j1] = tmp10;
            }
        }
        public void RemoveLastMultiple(int n)
        {
            if (n > Length)
            {
                throw new IndexOutOfRangeException();
            }

            else if (n > 0)
            {
                int[] tmpArray = new int[_array.Length];
                for (int i = 0; i < Length - n; i++)
                {
                    tmpArray[i] = _array[i];
                }
                _array = tmpArray;
                Length -= n;
            }


        }
        public void RemoveAtMultiple(int idx, int n)
        {
            int[] tmpArray = new int[_array.Length];
            for (int i = 0; i < Length; i++)
            {

                if (i < idx)
                {
                    tmpArray[i] = _array[i];
                }
                else if (i >= idx + n)
                {
                    tmpArray[i - n] = _array[i];
                }
            }

            Length -= n;
            _array = tmpArray;

        }
        public int RemoveFirst(int val)
        {

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == val)
                {
                    Array.Copy(_array, i + 1, _array, i, Length - i - 1);
                    _array[Length - 1] = 0;
                    Length--;
                    return i;

                }

            }
            return -1;
        }
        public int RemoveAll(int val)
        {
            
            int summery = 0;
            int[] tmpArray = new int[_array.Length];
            for (int i = 0; i < Length; i++)
            {

                if (_array[i] != val)
                {
                    tmpArray[i - summery] = _array[i];



                }
                if (_array[i] == val)
                {
                    summery++;
                }
            }
            Length -= summery;
            _array = tmpArray;
            return summery;
        }
        public bool Contains(int val)
        {
            foreach (var item in _array)
            {
                if (item == val)
                {
                    return true;
                }
            }
            return false;
        }
        public int Min()
        {
            int min = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {

                if (min > _array[i])
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public int Max()
        {
            int max = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {

                if (max < _array[i])
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int[] Reverse()
        {
            for (int i = 0; i < _array.Length / 2; i++)
            {

                int c = _array[i];
                _array[i] = _array[_array.Length - i - 1];
                _array[_array.Length - i - 1] = c;

            }
            return _array;

        }

        public int IndexOfMax()
        {
            int indexOfMaxElement = 0;
            int maxElement = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (maxElement < _array[i])
                {
                    maxElement = _array[i];
                    indexOfMaxElement = i;
                }

            }
            return indexOfMaxElement;
        }
        public int IndexOfMin()
        {
            int indexOfMaxElement = 0;
            int maxElement = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (maxElement > _array[i])
                {
                    maxElement = _array[i];
                    indexOfMaxElement = i;
                }

            }
            return indexOfMaxElement;
        }
        public int Get(int idx)
        {
            int m = 0;
            for (int i = 0; i < Length; i++)
            {
                if(i==idx)
                {
                    m = _array[idx];
                }
            }
            return m;
        }
        public int IndexOf(int val)
        {
            int m = -1;
            int idx = -1;
            while (m != val)
            {
                for (int i = 0; i < _array.Length; i++)
                {
               
                    if (_array[i] == val&&m!=val)
                    {
                        m = _array[i];
                        idx = i;
                    }
                }
            }
            
           
            return idx;
        }
    }
}
