using System;

namespace Inkrementacja.Lis
{
    class Program
    {
        static void Main()
        {
            /*1*/
            int x = 1, y;
            /*2*/
            Console.WriteLine(--x);
            /*3*/
            Console.WriteLine(x--);
            /*4*/
            Console.WriteLine(x);
            /*5*/
            y = x--;
            /*6*/
            Console.WriteLine(y);
            /*7*/
            y = --x;
            /*8*/
            Console.WriteLine(--y);

            

        }
    }
}
