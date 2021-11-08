//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace List
//{
//   public  class LinkedList
//    {
        
//        private Node _head;
//        private Node _tail;
      
//        public int this [int index]
//        {
//            get
//            {
//                Node current = _head;
//                for (int i = 1; i <= index; i++)//начинаем с 1 потому что нулевой элемент уже внутри cuurent
//                {
//                    current = current.Next;

//                }
//                return current.Value;

//            }
//            set
//            {
//                Node current = _head;
//                for (int i = 1; i <= index; i++)
//                {
//                    current = current.Next;

//                }
//                current.Value = value;
//            }
//        }
//        public void Set(int index, int value)
//        {
           
            
//                Node current = _head;
//                for (int i = 1; i <= index; i++)
//                {
//                    current = current.Next;

//                }
//                current.Value = value;
            
//        }
//        public LinkedList()
//        {
          
            
//            _head = null;//_head - первый элемент
//            _tail = null;
//        }
//        public LinkedList(int value)
//        {
           
//            _head = new Node(value);
//            _tail = _head;
//        }
        
       
        
//        public LinkedList (int[]values)
        
//        {
           
//            if (values.Length != 0)
//            {
               
//                _head = new Node(values[0]);
//                _tail = _head;
//                for (int i = 1; i < values.Length; i++)
//                {
//                    _tail.Next = new Node(values[i]);
//                    _tail = _tail.Next;
//                }
               
               
//            }
//            else
//            {
                
//                _head = null;
//                _tail = null;
//            }
//        }
//        public int[] ToArray()
//        {

//            int[] array = new int[GetLength()];
//            Node current = _head;

//            for (int i = 0; i <= array.Length - 1; i++)
//            {

//                 array[i]=current.Value;
//                current = current.Next;

//            }


//            return array;
//        }

//        public LinkedList Clone()
//        {
//            LinkedList linkedList = new LinkedList();
//            Node current = _head;
//            Node tmp;
//            Node newCurrent = linkedList._head;
//            int length = GetLength();
          
//            if (length != 0)
//            {

//                linkedList._head = new Node(current.Value);
//                linkedList._tail = linkedList._head;
//                for (int i = 1; i < length; i++)
//                {
//                    current = current.Next;
//                    linkedList._tail.Next = new Node(current.Value);
//                    linkedList._tail = linkedList._tail.Next;
                   
//                }


//            }
//            else
//            {

//                linkedList._head = null;
//                linkedList._tail = null;
//            }
//            //for (int i = 0; i < length; i++)
//            //{

//            //    newCurrent.Value = current.Value;
//            //    newCurrent = newCurrent.Next;
//            //    current = current.Next;




//            //}
//            return linkedList;
//        }


//        public void AddLast(int val)
//        {
//            Node current = new Node(val);
//            int length = GetLength();
//            if (length == 0)
//            {
//                _head = current;
//            }
//            else
//            {
//                _tail.Next = new Node(val);
//                _tail = _tail.Next;
//            }
//        }
//        public void AddFirst(int val)
//        {
           
//           Node tmp =new Node(val);
//            tmp.Next = _head;
//            _head = tmp;
//        }
//        public void RemoveAt(int index)
//        {
//            Node current = _head;
//            if (index == 0)
//            {
//                current = current.Next;
//                _head = current;
//            }
//            else
//            {


//                for (int i = 1; i < index; i++)
//                {
//                    current = current.Next;
//                }
//                current.Next = current.Next.Next;

//            }
            
//        }
       
//        ///_______________________________________________
//        public int  GetLength()
//        {
//            Node current = _head;
//            int Length = 0;
//            while (current!=null)
//            {
//               Length += 1;
//                current = current.Next;
//            }
            
//            return Length;
//        }
//        //__________________________________________________

//        public void AddLast(LinkedList list)
//        {
//            Node current= _head;
//            int Length = GetLength();
//            if (Length == 0)
//            {
//                _head = list._head;
//            }

//            for (int i = 1; i <Length; i++)
//            {
//                current = current.Next;
                
//                if(current.Next==null)
//                {
//                    current.Next = list._head;
//                }

//            }
            
//        }
//        public void AddFirst(LinkedList list)
//        {
            
//            LinkedList cloneList = list.Clone();
//            Node current = cloneList._head;
//            int length = cloneList.GetLength();
//            if(length==0)
//            {
//                return;
//            }
            
//            for (int i = 1; i < length; i++)
//            {               
//                current = current.Next;
//            }

//            current.Next=_head;
//            _head = cloneList._head;
            




//        }
//       public void RemoveLast()
//        {
//            Node current = _head;
//            int Length = GetLength();
//            for (int i = 1; i <Length-1; i++)
//            {
//                current = current.Next;

//            }
           
//            current.Next= null;
//        }
//        public void RemoveFirst()
//        {
//            if (GetLength() == 0)
//            {
//                throw new IndexOutOfRangeException("массив пуст");

//            }
//            _head = _head.Next;
           
//        }
//        public void AddAt(int idx, int val)
//        {
//            Node current = _head;
//            Node tmp = new Node(val);
//            int length = GetLength();
//            if(length==0)
//            {
//                throw new IndexOutOfRangeException(" тобi жопа");
//            }
//            for (int i = 0; i <=idx-1; i++)
//            {
//                tmp.Next = current.Next;
//                current.Next = tmp;

//            }
            
//        }
//        public int GetFirst()
//        {
//            Node current =_head;
//            return current.Value;
//            int length = GetLength();
//            if (length==0)
//            {
//                throw new NullReferenceException("Элементов в массиве нет");
//            }

//        }
//        public int GetLast()
//        {
//            Node current = _tail;
//            return current.Value;
//            if (current == null)
//            {
//                throw new NullReferenceException("Элементов в массиве нет");
//            }
//        }
//        public int Get(int idx)
//        {
//            Node current = _head;
//            int length = GetLength();
//            if (current == null)
//            {
//                throw new NullReferenceException("Элементов в массиве нет");
//            }
//            for (int i = 0; i < idx; i++)
//            {
//                current = current.Next;

//            }
//            return current.Value;
//        }
//        public int RemoveFirst(int val)
//        {
//            int index = 0;
//            Node current = _head;
//            int length = GetLength();

//            for (int i = 0; i < length; i++)
//            {
//                if (current.Value == val && i == 0)
//                {
//                    index = i;
//                    RemoveFirst();
//                    break;
//                }
//                if (current.Value == val && i == length - 1)
//                {
//                    index = i;
//                    RemoveLast();
//                    break;
//                }
//                if (current.Value == val&&i!=0)
//                {
//                    index = i;
                   
//                    _head.Next = current.Next;
//                    break;
//                }
//                else
//                {
//                    current = current.Next;
//                }

//            }
               
            
//            return index;
            
//        }
       
//        public int Max()
//        {
//            Node current = _head;
//            int length = GetLength();
//            int tmp=current.Value;
//            for (int i = 0; i < length-1; i++)
//            {
//                if(tmp<current.Next.Value)
//                {
//                    tmp = current.Next.Value;
//                }
//                current = current.Next;

//            }
//            return tmp;
//        }
//        public int Min()
//        {
//            Node current = _head;
//            int length = GetLength();
//            int tmp = current.Value;
//            for (int i = 0; i < length-1; i++)
//            {
//                if (current.Next.Value < tmp)
//                {
//                    tmp = current.Next.Value;
//                }
//                current = current.Next;

//            }
//            return tmp;
//        }
//        public int IndexOfMax()
//        {
//            Node current = _head;
//            int length = GetLength();
//            int max = current.Value;
//            int idx = 0;
//            for (int i = 1; i < length; i++)
//            {
//                if(max<current.Next.Value)
//                {
//                    idx = i;
//                    max = current.Next.Value;

//                }
                
//                current = current.Next;
//            }
//            return idx;
//        }
//        public void RemoveFirstMultiple(int n)
//        {
//            Node current = _head;
//            int length = GetLength();
//            for (int i = 0; i < n; i++)
//            {
//                current = current.Next;
//            }
//            _head = current;

//        }
//        public void RemoveLastMultiple(int n)
//        {
//            Node current = _head;
//            int length = GetLength();
//                for (int i = 0; i < length - n-1; i++)
//                    {
//                        current = current.Next;
//                    }
//            current.Next = null;
            
           

//        }
//        public void RemoveAtMultiple(int idx, int n)
//        {
//            Node current = _head;

//            int length = GetLength();
//            if(idx==0)
//            {
//                RemoveFirstMultiple(n);
//            }
//            for (int i = 0; i < idx-1; i++)
//            {
//                current = current.Next;
//            }
//            Node tmp = current;
//            for (int i = 0; i < n+1; i++)
//            {
//                tmp = tmp.Next;
                
//            }
//            current.Next = tmp;
            
//        }
//        public int RemoveAll(int val)
//        {
//            Node current = _head;
//            int length = GetLength();
//            int summery = 0;
            
//            for (int i = 0; i < length; i++)
//            {
//                if(current.Value==val)
//                {
//                    RemoveAt(i-summery);
//                    summery += 1;
                    
//                }
//                current = current.Next;
//            }
//            return summery;
//        }
//        public bool Contains(int val)
//        {
//            Node current = _head;
//            int length = GetLength();
           

//            for (int i = 0; i < length; i++)
//            {
//                if (current.Value == val)
//                {
//                    return true;
//                }
//                current = current.Next;
//            }
//            return false;
//        }
//        public int IndexOf(int val)
//        {
//            Node current = _head;
//            int length = GetLength();
//            int idx = -1;
//            for (int i = 0; i < length; i++)
//            {
//                if(current.Value==val)
//                {
//                    idx = i;
//                    break;
//                }
//                current = current.Next;
//            }
//            return idx;
//        }
//        public int IndexOfMin()
//        {
//            Node current = _head;
           
//            int length = GetLength();
//            int tmp = current.Value;
//            int idx = 0;
//            for (int i = 0; i < length-1; i++)
//            {

//                if(current.Next.Value<tmp)
//                {
//                    idx = i+1;
//                    tmp = current.Next.Value;
                   
//                }
//                current = current.Next;
//            }
//            return idx;
//        }
//        public void Reversee()
//        {
//            Node current = _head;
//            int length = GetLength();
//            int tmp = 0;
//            int tmp2 = 0;
//            for (int i = 0; i <= length/2-1; i++)
//            {
               
//                tmp = Get(i);
//                tmp2 = Get(length - i - 1);
//                Set(length - i - 1, tmp);
//                Set(i, tmp2);
//            }
           
           
//        }
//        public void Sort()
//        {
//            Node current = _head;
//            Node tmp1 = _head;
//            Node tmp2 = _head;
//            int length = GetLength();
//            int tmp = 0;


//            for (int i = 0; i < length - 1; i++)
//            {
//                tmp = Get(i);

//                while (tmp1.Next!=null)
//                { 
//                    if (current.Value > tmp1.Next.Value)
//                    {
//                        tmp = tmp1.Next.Value;
//                        tmp1.Next.Value = current.Value;
//                        //current.Value = tmp1.Next.Value;
//                        current.Value = tmp;

//                    }
//                    tmp1 = tmp1.Next;
//                }
//                current = current.Next;
//                tmp1 = current;
//            }
//        }
//        public void SortDesc()
//        {
//            Node current = _head;
//            Node tmp1 = _head;
//            Node tmp2 = _head;
//            int length = GetLength();
//            int tmp = 0;


//            for (int i = 0; i < length - 1; i++)
//            {
//                tmp = Get(i);

//                while (tmp1.Next != null)
//                {
//                    if (current.Value < tmp1.Next.Value)
//                    {
//                        tmp = tmp1.Next.Value;
//                        tmp1.Next.Value = current.Value;
                        
//                        current.Value = tmp;

//                    }
//                    tmp1 = tmp1.Next;
//                }
//                current = current.Next;
//                tmp1 = current;
//            }
//        }
       
//        public override string ToString()
//        {
//            return string.Join(";", ToArray());
//        }
//    }
//}
