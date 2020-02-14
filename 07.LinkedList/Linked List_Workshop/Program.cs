namespace LinkedListWorkshop
{
    using System;
    using System.Collections.Generic;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var linkedList = new CoolLinkedList();

            linkedList.AddHead(5);
            linkedList.AddHead(10);
            linkedList.AddHead(15);

            // 15 <-> 10 <-> 5

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 5);
            Console.WriteLine(linkedList.Count == 3);

            linkedList.AddTail(20);
            linkedList.AddTail(25);

            // 15 <-> 10 <-> 5 <-> 20 <-> 25

            linkedList.ForEach(Console.WriteLine);
            linkedList.ForEach(Console.WriteLine, reverse: true);

            var arr = linkedList.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 25);
            Console.WriteLine(linkedList.Count == 5);

            Console.WriteLine((int)linkedList.RemoveHead() == 15);
            Console.WriteLine((int)linkedList.RemoveHead() == 10);
            Console.WriteLine((int)linkedList.Head == 5);
            Console.WriteLine(linkedList.Count == 3);

            //5 <-> 20 <-> 25

            Console.WriteLine(linkedList.Contains(20));
            Console.WriteLine(linkedList.Contains(25));
            Console.WriteLine(linkedList.Contains(2) == false);
            Console.WriteLine((int)linkedList.RemoveTail() == 25);
            Console.WriteLine((int)linkedList.RemoveTail() == 20);
            Console.WriteLine((int)linkedList.RemoveTail() == 5);
            Console.WriteLine(linkedList.Count == 0);

            linkedList.AddTail(5);
            linkedList.AddTail(10);
            linkedList.AddTail(5);
            linkedList.AddTail(20);
            linkedList.AddTail(5);

            //5 <-> 10 <-> 5 <-> 20 <-> 5

            linkedList.Remove(5);

            //10 <-> 20

            Console.WriteLine((int)linkedList.Head == 10);
            Console.WriteLine((int)linkedList.Tail == 20);
            Console.WriteLine(linkedList.Count == 2);

            linkedList.Clear();
            Console.WriteLine(linkedList.Count == 0);
        }
    }
}
