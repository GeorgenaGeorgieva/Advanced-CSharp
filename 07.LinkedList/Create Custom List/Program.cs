using System;

namespace Create_Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();

            customList.Add(2);
            customList.Add(5);
            customList.Add(6);
            customList.Add(64);
            customList.Add(46);

            var obj = customList.RemoveAt(2);

            Console.WriteLine(customList.Contains(64));

            Console.WriteLine(customList[0]);

            customList.Swap(1, 3);

        }
    }
}
