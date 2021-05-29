using System;

namespace ConsoleApp5
{
    class IfDemo
    {
        static void Main()
        {
            int a, b, c;
            a = 2;
            b = 3;

            if (a < b) Console.WriteLine("a меньше b");
            // неподлежит выводу
            if (a == b) Console.WriteLine("этого никто не увидит");

            Console.WriteLine();
            c = a - b; // с содержит -1

            Console.WriteLine("c содержит -1");
            if (c >= 0) Console.WriteLine("значение с неотрицательно");
            if (c < 0) Console.WriteLine(" значение с отрицательно");
            Console.WriteLine();

            c = b - a; // теперь содержит 1
            Console.WriteLine(" содержит 1");
            if (c >= 0) Console.WriteLine("Значение с неотрицательно ");
            if (c < 0) Console.WriteLine("значение с отрицательно"); 


        }
    }
}
