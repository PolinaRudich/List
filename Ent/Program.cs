using LList;
using DList;
using List;

namespace Ent
{
    class Program
    {
        static void Main(string[] args)
        {
            ////DoublyLinkedList linkedList1 = new DoublyLinkedList(new int[] {1,2});
            DoublyLinkedList arrayList = new DoublyLinkedList(new int[] {1,2,3,4,5});
            //DoublyLinkedList list = new DoublyLinkedList(new int[] {});
          
            arrayList.Reversee();
            System.Console.WriteLine($"{arrayList}");
            //DoublyLinkedList linkedList = new DoublyLinkedList(new int[] { 1,2,3,4,5,6, 0 });
            //linkedList.IndexOfMin();
            //int actual = linkedList.IndexOfMin();
            //System.Console.WriteLine(($"{actual}")) ;
            //DoublyLinkedList a = new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5 });
            //    a.Reversee();
            //LinkedList linkedList1 = new LinkedList(new int[] { 5, 6, 7 });
            //LinkedList arr = new LinkedList(new int[] { 1,2,2,  4 });
            ////arr.ShiftToRight(0, 2);

            ////ArrayList list = new ArrayList(new int[] { 4,5 });
            //arr.RemoveFirst(1) ;

            //System.Console.WriteLine($"{arr}");
            //Console.WriteLine($"  {linkedList1}");


            //linkedList1();
            //int[] array = linkedList1.ToArray();
            //Console.WriteLine(array.Length);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item + " ");
            //}




        }
    }
}
