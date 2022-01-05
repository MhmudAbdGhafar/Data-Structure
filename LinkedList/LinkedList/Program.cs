using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedList lst = new linkedList();
            lst = lst.createWithLoop();
            Console.WriteLine(lst.hasLoop());
        }
    }
}
