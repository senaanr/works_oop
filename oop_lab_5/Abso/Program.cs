using Abso;
using System;






    public abstract int Extract();

    MaxHeap heap = new MaxHeap();
    heap.Insert(5);
        heap.Insert(1);
        heap.Insert(3);
        heap.Insert(2);
        heap.Insert(4);
         
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
        Console.WriteLine($"{heap.Extract()}");
    }


