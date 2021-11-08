using System;
using System.Linq;
using Ent;
namespace List
{
   public class ArrayList : IList
    {
       

            private int[] _array;
        private int _minLength =10;
            public int Length { get; private set; }
            public ArrayList()
            {
               
                _array = new int[_minLength];
            }
            public ArrayList(int value)
            {
                

                _array = new int[_minLength];
                _array[0] = value;

            }
            public ArrayList(int[] array)
            {
            Length = array.Length;
            int length;
           

            if (array.Length > _minLength)
            {
                length = array.Length;
            }
            else
            {
                length = _minLength;
            }
            int[] array1 = new int[length];
                for (int i = 0; i < Length; i++)
                {

                    array1[i] = array[i];
                }
              _array = array1;
           
            
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


                int newLength = (Length * 3) / 2 + 1;
                int[] tmpArray = new int[newLength];


                for (int i = 0; i < Length; i++)
                {
                    tmpArray[i] = _array[i];

                }
                _array = tmpArray;
            


        }
            public void UpSize(int newLength)
            {


            int length = (_array.Length + newLength) * 3 / 2;
                int[] tmpArray = new int[length];


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
        public int GetLength()
        {

            return Length;
        }
        public void ShiftToRight(int index, int n) //сдвиг вправо
        {
            if (Length + n > _array.Length)
            {
                
                UpSize(n);
                
            }
            Length += n;
            for (int i = Length-1; i > index+n-1; i--)
            {
                _array[i] = _array[i - n];
                
            }
   
        }
        public void AddFirst(int value)
            {
                if (Length == _array.Length)
                {
                    UpSize();
                }
                ShiftToRight(0, 1);
            _array[0] = value;
                //Length++;
               
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
            
            public void AddAt(int idx, int val)
            {
            if (idx > Length - 1)
            {
                throw new IndexOutOfRangeException("");
            }
            if (Length == _array.Length)
                {
                    UpSize();
                }

            ShiftToRight(idx, 1);
                _array[idx] = val;
                //Length++;
               
            }

            public void AddFirst(ArrayList list)
            {
                    if(_array.Length-list.Length<=0)
                    {
                        UpSize(list.Length);
                        
                    }
            
            ShiftToRight(0, list.Length);
           
            for (int i = 0; i < list.Length; i++)
                    {
                         _array[i] = list[i];

                    }
            }
            public void AddLast(ArrayList list)
            {
            if (_array.Length == Length)
            {
                UpSize(list.Length);
            }
            for (int i = 0; i < list.Length; i++)
            {
                _array[Length+i] = list[i];
               
            }
            Length+=list.Length;
            

        }
            public void AddAt(int idx, ArrayList list)
            {
                if (Length == 0)
                {
                    throw new IndexOutOfRangeException("массив пуст");

                }
                UpSize( list.Length);
            ShiftToRight(idx, list.Length);
                for (int i = 0; i < list.Length; i++)
                {
                    _array[i + idx] = list[i];
                }
               

            }
            public void RemoveFirst()
            {
                if (Length == 0)
                {
                    throw new IndexOutOfRangeException("массив пуст");

                }
            //ShiftToRight(0, 1);
            for (int i = 0; i < Length-1; i++)
            {
                _array[i] = _array[i + 1];
                
            }
            Length--;


        }
            public void RemoveLast()
            {
                if (Length == 0)
                {
                    throw new Exception("Длинна списка ноль");

                }
                Length--;
                
            }
            public  bool Equals(object obj)
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
                if(idx>Length-1||idx<0)
            {
                throw new Exception("Нет элемента под этим индексом или индекс отрицательный");
            }

                if ((idx >= 0) && (idx < Length))
                {
                    for (int i = idx; i < Length - 1; i++)
                    {
                        _array[i] = _array[i + 1];
                    }
                    Length--;
                }

                
            }
            public void RemoveFirstMultiple(int n)
            {
                if (Length == 0)
                {
                    throw new IndexOutOfRangeException("массив пуст");

                }
                if(Length<n)
                {
                    throw new Exception("Нет столько элементов в листе");
                }
            if (n > 0 && n != Length)
            {
                int[] tmpArray = new int[_array.Length];
                for (int i = 0; i < n; i++)
                {
                    tmpArray[i] = _array[i + n];
                }
                _array = tmpArray;
                Length -= n;
                
            }
             else if (Length == n)
            {
                Length = 0;
                
            }
            
            
        }
            public int GetFirst()
            {
                if (Length == 0)
                {
                    throw new IndexOutOfRangeException("массив пуст");

                }
                   int n = _array[0];
                
                return n;

            }
            public int GetLast()
            {

            if (Length == 0)
            {
                throw new IndexOutOfRangeException("массив пуст");

            }
            int n = _array[Length-1];

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
                if(Length<n)
                   {
                    throw new Exception("Нет стольки элементов в листе");
                     }
                else if (n > 0)
                {
                Length-=n;
            }


            }
            public void RemoveAtMultiple(int idx, int n)
            {
            if (n > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length < n)
            {
                throw new Exception("Нет стольки элементов в листе");
            }
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
             if(Length==0)
            {
                throw new IndexOutOfRangeException();
            }
            int index = IndexOf(val);
                if (index != -1)
                {
                    index = IndexOf(val);
                    RemoveAt(index);


                }
                return index;
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
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            int min = _array[0];
                for (int i = 0; i < this.Length; i++)
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
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
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
           
              if(Length==0)
            {
                throw new IndexOutOfRangeException("");
            }
            if (this.Length % 2 == 0)
                {
                for (int i = 0; i < _array.Length / 2-1; i++)
                {

                    int c = this[i];
                    this[i] = this[this.Length - i - 1];
                    this[this.Length - i - 1] = c;

                }
            }
            else
            {
                for (int i = 0; i < _array.Length / 2; i++)
                {

                    int c = this[i];
                    this[i] = this[this.Length - i - 1];
                    this[this.Length - i - 1] = c;

                }
            }
            return _array;

            }

            public int IndexOfMax()
            {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
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
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
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
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            int m = 0;
                m = _array[idx];
                return m;
            }
            public int IndexOf(int val)
            {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            int idx = -1;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == val )
                {
                    
                    idx = i;
                    break;
                }
            }
            return idx;
        }
        public  string ToString()
        {
            return string.Join(";", ToArray());
        }
    }
    }

