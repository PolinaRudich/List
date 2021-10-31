using System;
using List;

namespace Ent
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList1 = new LinkedList(new int[] {3,2,0,-9999,6,7,2,0,-12,3,4,4,4,5,5,7,4,7,5,66,66,1});
            
            linkedList1.SortDesc();
             int[] array = linkedList1.ToArray();
            Console.WriteLine(array.Length);
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }
          



        }
    }
}
