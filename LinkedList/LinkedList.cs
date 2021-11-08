using System;
using Ent;

namespace LList
{
    public class LinkedList:  IList
    {

        private Node _head;
        private Node _tail;

        public int this[int index]
        {
            get
            {
                if(index>GetLength()-1)
                {
                    throw new IndexOutOfRangeException();
                }
                if(index<0)
                {
                    throw new IndexOutOfRangeException();
                }
                if (GetLength()==0)
                {
                    throw new Exception("массив пуст");
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
            if(index>length-1)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;

            }
            current.Value = value;

        }
        public LinkedList()
        {


            _head = null;//_head - первый элемент
            _tail = null;
        }
        public LinkedList(int value)
        {

            _head = new Node(value);
            _tail = _head;
        }



        public LinkedList(int[] values)

        {

            if (values.Length != 0)
            {

                _head = new Node(values[0]);
                _tail = _head;
                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }


            }
            else
            {

                _head = null;
                _tail = null;
            }
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

        public LinkedList Clone()
        {
            LinkedList linkedList = new LinkedList();
            Node current = _head;
            Node tmp;
            Node newCurrent = linkedList._head;
            int length = GetLength();

            if (length != 0)
            {

                linkedList._head = new Node(current.Value);
                linkedList._tail = linkedList._head;
                for (int i = 1; i < length; i++)
                {
                    current = current.Next;
                    linkedList._tail.Next = new Node(current.Value);
                    linkedList._tail = linkedList._tail.Next;

                }


            }
            else
            {

                linkedList._head = null;
                linkedList._tail = null;
            }
            //for (int i = 0; i < length; i++)
            //{

            //    newCurrent.Value = current.Value;
            //    newCurrent = newCurrent.Next;
            //    current = current.Next;




            //}
            return linkedList;
        }

            ///&&&&&&&&&&&&&&&&&&&&&
        public void AddLast(int val)
        {
            Node current = new Node(val);
            //int length = GetLength();
            if (_head!=null)
            {
                _tail.Next = new Node(val);
                _tail = _tail.Next;
                
            }
            else
            {
                _head = current;
                _tail = _head;
                //throw new I
            }
        }
        public void AddFirst(int val)
        {

            Node tmp = new Node(val);
            tmp.Next = _head;
            _head = tmp;
        }
        public void RemoveAt(int index)
        {
            Node current = _head;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            if (index == 0)
            {
                current = current.Next;
                _head = current;
            }
            else
            {


                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;

            }

        }

        ///_______________________________________________
        public int GetLength()
        {
            Node current = _head;
            int length = 0;
            while (current != null)
            {
                length += 1;
                current = current.Next;
            }

            return length;
        }
        //__________________________________________________

        public void AddLast(LinkedList list)
        {
            Node current = _head;
            int Length = GetLength();
            if (Length == 0)
            {
                _head = list._head;
                _tail = list._tail;
            }
            _tail.Next = list._head;
            _tail = list._tail;
            //for (int i = 1; i < Length; i++)
            //{
            //    current = current.Next;

            //    if (current.Next == null)
            //    {
            //        current.Next = list._head;
            //        _tail = list._tail;
            //    }

            //}

        }
        public void AddFirst(LinkedList list)
        {

            LinkedList cloneList = list.Clone();
            Node current = cloneList._head;
            int length = cloneList.GetLength();
            if (length == 0)
            {
                return;
            }

            //for (int i = 1; i < length; i++)
            //{
            //    current = current.Next;
            //}
            cloneList._tail.Next = _head;
            //cloneList._head = _head;
            //current.Next = _head;
            _head = cloneList._head;





        }
        public void RemoveLast()
        {
            Node current = _head;
            
            if(_head==null)
            {
                throw new NullReferenceException();
            }
            if (current.Next == null)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
            }

            current.Next = null;
        }
        public void RemoveFirst()
        {
            Node current = _head;
            if (_head == null)
            {
                throw new NullReferenceException();
            }
            if (current.Next == null)
            {
                _head = null;
                _tail = null;
            }
            _head = _head.Next;

        }
        public void AddAt(int idx, int val)
        {
            Node current = _head;
            Node insertedNode = new Node(val);
            //Node current = _head;
            //Node tmp = new Node(val);
            //int length = GetLength();
            if (idx == 0)
            {
                insertedNode.Next = _head;
                _head = insertedNode;
            }
            else
            {
                if (_head == null)
                {
                    throw new IndexOutOfRangeException();
                }
                if (current.Next == null)
                {
                    _head = null;
                    _tail = null;
                }

                for (int i = 0; i < idx - 1; i++)
                {
                    current = current.Next;

                }
                insertedNode.Next = current.Next;
                current.Next = insertedNode;
            }
            //for (int i = 0; i <= idx - 1; i++)
            //{
            //    current = current.Next;

            //}

            //tmp.Next = current.Next;
            //current.Next = tmp;

        }
        public void AddAt(int idx,LinkedList list)
        {
            Node current = _head;
            if(idx==0)
            {
                list._tail.Next = _head;
                _head = list._head;
            }
            else
            {
                if (_head == null)
                {
                    throw new IndexOutOfRangeException();
                }
                

                for (int i = 0; i < idx - 1; i++)
                {
                    current = current.Next;

                }
                list._tail.Next = current.Next;
                current.Next = list._head;
              

            }

        }
        public int GetFirst()
        {
            Node current = _head;
            return current.Value;
            
            if (_head==null)
            {
                throw new NullReferenceException("Элементов в массиве нет");
            }

        }
        public int GetLast()
        {
            Node current = _tail;
            return current.Value;
            if (current == null)
            {
                throw new NullReferenceException("Элементов в массиве нет");
            }
        }
        public int Get(int idx)
        {
            return this[idx];
        }
        public int RemoveFirst(int val)
        {
            int index = -1;

            Node tmp = new Node(0);
            

           tmp.Next = _head;
             Node current = tmp;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            while (current.Next!=null)
               {
                index += 1;
                if (current.Next.Value==val)
                {

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
            Node current = _head;
            int length = GetLength();
            int tmp = current.Value;
            if (_head == null)
            {
                throw new Exception("массив пуст");
            }
            while (current.Next!=null)
            {
                if (tmp < current.Next.Value)
               {
                   tmp = current.Next.Value;
               }
                current = current.Next;
            }
           
            return tmp;
        }
        public int Min()
        {
            Node current = _head;
            int length = GetLength();
            int tmp = current.Value;
            if (_head == null)
            {
                throw new Exception("массив пуст");
            }
            while (current.Next!=null)
            {
                if (current.Next.Value < tmp)
                {
                    tmp = current.Next.Value;
                }
                current = current.Next;
            }
            return tmp;
        }
        public int IndexOfMax()
        {
            Node current = _head;
            //int length = GetLength();
            int max = current.Value;
            int idx = 0;
            int i = 0;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            while (current.Next!=null)
            {
                i += 1;
                if (max<current.Next.Value)
                {
                    idx = i;
                    max = current.Next.Value;
                }
                
                current = current.Next;
            }
           
            return idx;
        }
        public void RemoveFirstMultiple(int n)
        {
            Node current = _head;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            for (int i = 0; i < n; i++)
            {
                current = current.Next;
            }
            _head = current;


        }
        public void RemoveLastMultiple(int n)
        {
            Node current = _head;
            int length = GetLength();
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            for (int i = 0; i < length - n - 1; i++)
            {
                current = current.Next;
            }
            current.Next = null;



        }
        public void RemoveAtMultiple(int idx, int n)
        {
            Node current = _head;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            //int length = GetLength();
            if (idx == 0)
            {
                RemoveFirstMultiple(n);
            }
            for (int i = 0; i < idx - 1; i++)
            {
                current = current.Next;
            }
            Node tmp = current;
            for (int i = 0; i < n + 1; i++)
            {
                tmp = tmp.Next;

            }
            current.Next = tmp;

        }
        public int RemoveAll(int val)
        {
            
            int length = GetLength();
            int summary = 0;
            Node tmp = new Node(0);
            tmp.Next = _head;
            Node current = tmp;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            while (current.Next != null)
            {

                if (current.Next.Value == val)
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
            Node current = _head;
            int length = GetLength();

            

            if (_head == null)
            {
                return false;
            }
            while (current.Next != null)
            {
                if (current.Value == val)
                {
                    return true;
                }
                current = current.Next;
            }


            return false;
            //if (_head == null)
            //{
            //    throw new Exception("Нечего сортировать");
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    if (current.Value == val)
            //    {
            //        return true;
            //    }
            //    current = current.Next;
            //}
            //return false;
        }
        public int IndexOf(int val)
        {
            Node current = _head;
            Node tmp = new Node(0);
            //_tail.Next = tmp;
            //_tail = tmp;
            //_head.Next = tmp;
            //Node current = tmp;
            
            int idx = -1;
            int i = 0;
            //for (int i = 0; i < length; i++)
            //{
            if (_head==null)
            {
                throw new Exception("массив пуст");
            }
            while (current != null)
            {

                if (current.Value == val)
                {
                    idx =  i;
                    
                    break;
                }
                i += 1;
                current = current.Next;
            }
            
            //}
            return idx;
            //Node current = _head;
            //int length = GetLength();
            //int idx = -1;
            //if (_head == null)
            //{
            //    throw new Exception("Нечего сортировать");
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    if (current.Value == val)
            //    {
            //        idx = i;
            //        break;
            //    }
            //    current = current.Next;
            //}
            //return idx;
        }
        public int IndexOfMin()
        {

            Node current = _head;

         
            int tmp = current.Value;
            int idx = 0;
            int i = 0;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            while (current.Next != null)
            {
                i += 1;
                if (current.Next.Value < tmp)
                {
                    idx = i ;
                    tmp = current.Next.Value;

                }
                current = current.Next;
            }
            //for (int i = 0; i < length - 1; i++)
            //{

            //    if (current.Next.Value < tmp)
            //    {
            //        idx = i + 1;
            //        tmp = current.Next.Value;

            //    }
            //    current = current.Next;
            //}
            return idx;
        }
        public void Reversee()
        {
            if(_head==null)
            {
                throw new Exception("Нечего сортировать");
            }
            Node current = _head;
            Node prev =null;
            Node next =_head;
             
            while(current!=null)
            {
                
               
               next = next.Next;
                current.Next = prev;
              
                prev = current;
                current = next;
            }
            _head = prev;
            
        }
        public void Sort()
        {
            Node current = _head;
            LinkedList sorted = new LinkedList();
            Node nxt = null;
           
            while (current!=null)
            {
                nxt = current.Next;
                sorted = Insertion(sorted, current);
                current = nxt;
            }

            _head = sorted._head;
        }
        public static LinkedList Insertion(LinkedList sorted,Node node)
        {
            if(sorted._head==null||sorted._head.Value>=node.Value)
            {
                node.Next = sorted._head;
                sorted._head = node;

            }
            else
            {
                Node current = sorted._head;
                while (current.Next!=null&&current.Next.Value<node.Value)
                {
                    current = current.Next;
                }
                node.Next = current.Next;
                current.Next = node;
            }
            return sorted;
        }

        public void SortDesc()
        {
            Node current = _head;
            LinkedList sorted = new LinkedList();
            Node nxt = null;
            if (_head == null)
            {
                throw new Exception("Нечего сортировать");
            }
            while (current != null)
            {
                nxt = current.Next;
                sorted = InsertionDesc(sorted, current);
                current = nxt;
            }

            _head = sorted._head;
        }
        public LinkedList InsertionDesc(LinkedList sorted, Node node)
        {
            if (sorted._head == null || sorted._head.Value <= node.Value)
            {
                node.Next = sorted._head;
                sorted._head = node;

            }
            else
            {
                Node current = sorted._head;
                while (current.Next != null && current.Next.Value >node.Value)
                {
                    current = current.Next;
                }
                node.Next = current.Next;
                current.Next = node;
            }
            return sorted;
        }
        public override string ToString()
        {
            return string.Join(";", ToArray());
        }
    }
}
