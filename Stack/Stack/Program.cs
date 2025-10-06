using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push(10);
            s1.Push(20);
            s1.Push(30);

            Console.WriteLine($"Top : {s1.Top}");

            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Console.ReadKey();
        }
    }
}
