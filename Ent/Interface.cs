using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ent
{
   public  interface IList
    {
       
        void AddLast(int  value);
        int[] ToArray();
       int GetLength();
        void AddFirst(int value);
        void AddAt(int idx, int val);
        void RemoveFirst();
        void RemoveLast();
         void RemoveAt(int idx);
        void RemoveFirstMultiple(int n);
        int GetFirst();
        int GetLast();
        void Sort();
        void SortDesc();
        void RemoveLastMultiple(int n);
        void RemoveAtMultiple(int idx, int n);
        int RemoveFirst(int val);
        int RemoveAll(int val);
        bool Contains(int val);
        int Min();
        int Max();
        int[] Reverse();
        int IndexOfMax();
        int IndexOfMin();
        int Get(int idx);
        int IndexOf(int val);


    }
}
