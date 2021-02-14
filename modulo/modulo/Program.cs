using System;

namespace modulo
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = 10;
            b = 25;
            c = b % a;
            Console.WriteLine("b % a = " + c);
            Console.WriteLine("11 % 3 = " + 11 % 3);
            c = a * b;
            Console.WriteLine("(a * b) % 120 = " + c % 120);

        }
    }
}
