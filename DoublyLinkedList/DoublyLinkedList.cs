using System;
using DList;
using Ent;

namespace DList
{
    public class DoublyLinkedList : IList
    {
        private Node _head;
        private Node _tail;
        public int this[int index]
        {
            get
            {
                if (index > GetLength() - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                if (index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                if (GetLength() == 0)
                {
                    throw new IndexOutOfRangeException("массив пуст");
                }
                Node current = _head;
                for (int i = 1; i <= index; i++)//начинаем с 1 потому что нулевой элемент уже внутри cuurent
                {
                    current = current.Next;

                }
                return current.Value;
            }
            set
            {
                if (index > GetLength() - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                if (index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                if (GetLength() == 0)
                {
                    throw new Exception("массив пуст");
                }
                Node current = _head;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;

                }
                current.Value = value;
            }
        }
        public void Set(int index, int value)
        {
            Node current = _head;
            int length = GetLength();
            if (index > length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;

            }
            current.Value = value;
        }
        public DoublyLinkedList()
        {


            _head = null;//_head - первый элемент
            _tail = null;
        }
        public DoublyLinkedList(int value)
        {

            _head = new Node(value);
            _tail = _head;
        }
        public DoublyLinkedList(int[] values)

        {

            if (values.Length != 0)
            {

                _head = new Node(values[0]);
                Node current = _head;
                _tail = _head;
                for (int i = 1; i < values.Length; i++)
                {

                    _tail.Next = new Node(values[i]);

                    _tail = _tail.Next;

                    _tail.Prev = current;
                    current = current.Next;
                }


            }
            else
            {

                _head = null;
                _tail = null;
            }
        }
        public DoublyLinkedList Clone()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            Node newCurrent = doublyLinkedList._head;
            int length = GetLength();
            Node current = _head;

            if (length != 0)
            {

                doublyLinkedList._head = new Node(current.Value);
                doublyLinkedList._tail = doublyLinkedList._head;
                for (int i = 1; i < length; i++)
                {
                    current = current.Next;
                    doublyLinkedList._tail.Next = new Node(current.Value);

                    doublyLinkedList._tail = doublyLinkedList._tail.Next;
                    doublyLinkedList._tail.Prev = doublyLinkedList._head;
                }


            }
            else
            {

                doublyLinkedList._head = null;
                doublyLinkedList._tail = null;
            }
            return doublyLinkedList;
        }
        public int GetLength()
        {
            Node current = _head;
            int Length = 0;
            while (current != null)
            {
                Length += 1;
                current = current.Next;
            }
            return Length;
        }
        public int[] ToArray()
        {
            int[] array = new int[GetLength()];
            Node current = _head;

            for (int i = 0; i <= array.Length - 1; i++)
            {

                array[i] = current.Value;
                current = current.Next;

            }
            return array;
        }
        public override string ToString()
        {
            return string.Join(";", ToArray());
        }
        public void AddLast(int val)
        {

            Node current = new Node(val);
            Node tmp;
      
            if (_head!=null)
            {
                _tail.Next = new Node(val);
                tmp = _tail;

                _tail = _tail.Next;
                _tail.Prev = tmp;
              
            }
            else
            {
                _head = current;
                _tail = _head;
               

            }
        }
        public void AddFirst(int val)
        {
            Node tmp1;
            Node tmp = new Node(val);
            if(_head==null)
            {
                _head = tmp;
                _tail = _head;
            }
            else
            {
                tmp1 = _head;
                _head.Prev = tmp1;
                tmp.Next = _head;

                _head = tmp;
            }
           
        }
        public void RemoveAt(int index)
        {
            Node current = _head;
            Node tmp;
            if(index>GetLength()-1)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                current = current.Next;
                _head = current;
                _head.Prev = null;
            }
            else
            {


                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                tmp = current.Next.Next;
                current.Next = tmp;
                tmp.Prev = current;



            }

        }
        public void AddLast(DoublyLinkedList list)
        {
            DoublyLinkedList cloneDoublyLinkedList = list.Clone();
            Node current = _head;
            Node tmp;
            int Length = GetLength();
            if (_head != null&& cloneDoublyLinkedList._head != null)
            {
                _tail.Next = cloneDoublyLinkedList._head;
                cloneDoublyLinkedList._head.Prev = _tail;
                _tail = cloneDoublyLinkedList._tail;


            }
            
            else if(cloneDoublyLinkedList._head != null)
            {
                _head = cloneDoublyLinkedList._head;

            }
            //if (Length == 0)
            //{
            //    _head = cloneDoublyLinkedList._head;
            //}
            //if (cloneDoublyLinkedList.GetLength() != 0)
            //{

            //    for (int i = 1; i < Length; i++)
            //    {
            //        current = current.Next;

            //        if (current.Next == null)
            //        {
            //            tmp = current;
            //            current.Next = cloneDoublyLinkedList._head;
            //            cloneDoublyLinkedList._head.Prev = tmp;
            //        }

            //    }
            //}



        }
        public void AddFirst(DoublyLinkedList list)
        {
            DoublyLinkedList doublyLinkedList = list.Clone();
            Node current = doublyLinkedList._head;
            Node tmp;

            int length = doublyLinkedList.GetLength();
            if (length == 0)
            {

                return;
            }
            if (GetLength() == 0)
            {
                _head = current;
            }
            else
            {
                //for (int i = 1; i < length; i++)
                //{
                    //current = current.Next;
                //}

                doublyLinkedList._tail.Next = _head;
                tmp = current.Next;
                tmp.Prev = doublyLinkedList._head;
                _head = doublyLinkedList._head;

            }




        }
        public void RemoveLast()
        {
            Node current = _head;
            Node tmp;
           
            if (GetLength() == 0)
            {
                throw new Exception("удалять нечего");
            }

            //while(current.Next.Next!=null)
            //{
            //    current = current.Next;
            //}
            if(_head.Next==null)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _tail.Prev.Next = null;
            }
           
           
            //tmp.Next.Prev = null;
            //tmp.Next = null;


        }
        public void RemoveFirst()
        {
            if (GetLength() == 0)
            {
                throw new Exception("удалять нечего");
            }
            if (_head.Next == null)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Prev = null;
            }
          

        }
        public void AddAt(int idx, int val)
        {
            if(GetLength()==0)
            {
                throw new Exception("пустой массив");
            }
            Node current = _head;
            Node tmp = new Node(val);
            if (idx == 0)
            {
                tmp.Next = current;
                _head = tmp;
            }
            else
            {
                for (int i = 0; i < idx - 1; i++)
                {
                    current = current.Next;

                }
                tmp.Next = current.Next;
                current.Next = tmp;
            }
            //Node current = _head;
            //Node tmp = new Node(val);

            //Node tmp1 = new Node(0);
            //tmp1.Next = _head;
            // current = tmp;
            //int length = GetLength();
            //int i = 0;
            ////for (int i = 0; i <= idx - 1; i++)
            ////{
            //while (current.Next!=null)
            //{
            //    if (i == idx)
            //    {
            //        tmp.Next = current.Next;
            //        current.Next = tmp;
            //        tmp.Prev = current;
            //       tmp1.Next = _head;
            //    }
            //    i += 1;
            //    current = current.Next;
            //}

            //}


        }
        public int GetFirst()
        {
            if (_head == null)
            {
                throw new NullReferenceException("Элементов в массиве нет");
            }
            Node current = _head;
            current.Prev = null;
            return current.Value;
           
            
        }
        //????????????????
        public int GetLast()
        {
            Node current = _tail;
            if (current == null)
            {
                throw new NullReferenceException("Элементов в массиве нет");
            }
            return current.Value;
   

        }
        //???????????
        public int Get(int idx)
        {
            return this[idx];
            //Node current = _head;
            //int length = GetLength();
            //if (current == null)
            //{
            //    throw new NullReferenceException("Элементов в массиве нет");
            //}
            //if (idx >= length)
            //{
            //    throw new IndexOutOfRangeException("");
            //}
            //for (int i = 0; i < idx; i++)
            //{
            //    current = current.Next;

            //}
            //return current.Value;
        }
        public int RemoveFirst(int val)
        {
            int index = -1;
            Node tmp = new Node(0);
            tmp.Next = _head;
            Node current =tmp;
            //int length = GetLength();
            //for (int i = 0; i < length; i++)
            //{
            //    if (current.Value == val && i == 0)
            //    {
            //        index = i;
            //        RemoveFirst();
            //        break;
            //    }
            //    if (current.Value == val && i == length - 1)
            //    {
            //        index = i;
            //        RemoveLast();
            //        break;
            //    }
            while (current.Next!=null)
            {
                index += 1;
                if (current.Next.Value == val)
                {



                    current.Next.Next.Prev = current;
                    current.Next = current.Next.Next;
                    _head = tmp.Next;
                    return index;
                }
                else
                {
                    current = current.Next;
                }
            }
            return index;
        }
        public int Max()
        {

            int length = GetLength();
            Node current = _tail;
            int tmp = current.Value;
            for (int i = 0; i < length - 1; i++)
            {
                if (tmp < current.Prev.Value)
                {
                    tmp = current.Prev.Value;
                }
                current = current.Prev;

            }
            return tmp;
        }
        public int Min()
        {

            int length = GetLength();
            Node current = _tail;
            int tmp = current.Value;
            for (int i = 0; i < length - 1; i++)
            {
                if (tmp > current.Prev.Value)
                {
                    tmp = current.Prev.Value;
                }
                current = current.Prev;

            }
            return tmp;
        }
        public int IndexOfMax()
        {
            Node current = _tail;
            int length = GetLength();
            int max = current.Value;
            int idx =length-1;
            int i = 0;
            while (current.Prev!=null)
            {

                i = length-= 1;
                if (max < current.Prev.Value)
                {
                     idx=i-1;
                    max = current.Prev.Value;

                }
               
                current = current.Prev;
            }
               
           
            return idx;

        }
        public void RemoveFirstMultiple(int n)
        {
            if(_head==null)
            {
                throw new IndexOutOfRangeException();
            }
           
            Node current = _tail;
            int length = GetLength();
            if (n > length)
            {
                throw new IndexOutOfRangeException();

            }
            if (length == n)
            {
                _head = null;
            }
            else
            {


                int i = 1;
                while (i != length - n)
                {

                    current = current.Prev;
                    i += 1;
                }
                _head = current;
            }
                

          
            
            current.Prev = null;

        }
        public void RemoveLastMultiply(int n)
        {
            Node current = _tail;
            int length = GetLength();
            int i = 1;
            if (length == n)
            {
                _head = null;
            }
            else
            {


                while (i != n + 1)
                {
                    i += 1;
                    current = current.Prev;
                }
                current.Next = null;
                _tail = current;
            }
            

        }
        public void RemoveAtMultiple(int idx, int n)
        {
            Node current = _tail;
            int length = GetLength();
            if (idx == 0)
            {
                RemoveFirstMultiple(n);
            }
            else if (idx == length - 1)
            {
                RemoveLastMultiply(n);
            }
            else if (idx <= length / 2)
            {
                Node currentTmp = _head;
                for (int i = 0; i < idx - 1; i++)
                {
                    currentTmp = currentTmp.Next;
                }
                Node tmp1 = currentTmp;
                for (int i = 0; i < n + 1; i++)
                {
                    tmp1 = tmp1.Next;

                }
                currentTmp.Next = tmp1;
                tmp1.Prev = currentTmp;
            }
            else
            {
                for (int i = 0; i < length - idx - 1; i++)
                {
                    current = current.Prev;
                }
                Node tmp = current;
                for (int i = 0; i < n + 1; i++)
                {
                    tmp = tmp.Prev;

                }
                current.Prev = tmp;
                tmp.Next = current;
            }
        }
        public int RemoveAll(int val)

        {
            //Node current = _head;
            int length = GetLength();
            int summary = 0;

            Node tmp = new Node(0);
            tmp.Next = _head;
            Node current = tmp;
            while (current.Next!=null)
            {
                if(current.Next.Value==val)
                {
                    
                    current.Next = current.Next.Next;
                    
                    _head = tmp.Next;
                    summary += 1;
                }
                else
                {
                    current = current.Next;
                }
            }
           
            return summary;
        }
        public bool Contains(int val)
        {
            Node current = _tail;
           
            if(_head==null)
            {
                return false;
            }
            while (current.Prev!=null)
            {
                if (current.Value == val)
                {
                    return true;
                }
                current = current.Prev;
            }
               
            
            return false;
        }
        public int IndexOf(int val)
        {
            Node current = _tail;
            Node tmp = new Node(0);
            tmp.Next = _head;
            _head.Prev = tmp;
            //Node current = tmp;
            int length = GetLength();
            int idx = -1;
            int i = 0;
            //for (int i = 0; i < length; i++)
            //{
            if (length == 0)
            {
                throw new Exception("массив пуст");
            }
            while (current.Prev!=null)
            {
                
                if (current.Value == val)
                {
                    idx = length - i - 1;
                    
                    //break;
                }
                i += 1;
                current = current.Prev;
            }
            _head = tmp.Next;
            //}
            return idx;
        }
        public int IndexOfMin()
        {
            Node current = _tail;

            int length = GetLength();
            int tmp = current.Value;
            int idx = length-1;
            int i = length;
            if (length == 0)
            {
                throw new Exception("массив пуст");
            }
            while (current.Prev!=null)
            {
                i -= 1;
                if (current.Prev.Value < tmp)
                {
                    idx = i - 1;
                    tmp = current.Prev.Value;

                }
                current = current.Prev;
            }
                
               
           
            return idx;
        }
        public void Reversee()
        {
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            Node current = _head;

            Node tmp = null;

            while (current != null)
            {
                
                tmp = current.Prev;
                current.Prev = current.Next;
                current.Next = tmp;
                current = current.Prev;
            }
            if (tmp != null)
            {
                _head = tmp.Prev;
            }
            //tmp = _head;
        


        }
        public static DoublyLinkedList InsertionDoublyLinkedList(DoublyLinkedList sorted, Node node)
        {
            if (sorted._head == null || sorted._head.Value > node.Value)
            {
                node.Next = sorted._head;
                sorted._head = node;
               
            }
            else
            {
                Node current = sorted._head;
                while (current.Next != null && current.Next.Value < node.Value)
                {
                    current = current.Next;
                }
                node.Next = current.Next;
                current.Next = node;
                node.Prev = current;
            }
            return sorted;
        }
        public void Sort()
        {
            //Node current = _head;
            //DoublyLinkedList sorted = new DoublyLinkedList();
            //Node nxt = null;
            //while (current!=null)
            //{
            //    nxt = current.Next;
            //    //sorted 
            //}
            Node current = _head;
            DoublyLinkedList sorted = new DoublyLinkedList();
            Node nxt = null;

            while (current != null)
            {
                nxt = current.Next;
                sorted = InsertionDoublyLinkedList(sorted, current);
                current = nxt;
            }

            _head = sorted._head;
        }
        public void SortDesc()
        {
            Node current = _head;
            DoublyLinkedList sorted = new DoublyLinkedList();
            Node nxt = null;
            while (current!=null)
            {
                nxt = current.Next;
                sorted = InsertionDesc(sorted, current);
                current = nxt;
            }
            _head = sorted._head;
        }
        public DoublyLinkedList InsertionDesc(DoublyLinkedList sorted, Node node)
        {
            if(sorted._head==null|| sorted._head.Value < node.Value)
            {
                node.Next = sorted._head;
                sorted._head = node;
            }
            else
            {
                Node current = sorted._head;
                while (current.Next != null&&current.Next.Value>node.Value)
                {
                    current = current.Next;
                }
                node.Next = current.Next;
                current.Next = node;
                node.Prev = current;
            }
            return sorted;
        }

    }
}
