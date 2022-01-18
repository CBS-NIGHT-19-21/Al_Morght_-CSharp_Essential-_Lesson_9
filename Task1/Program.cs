using System;

namespace Task1
{
    internal class Program
    {
        public delegate int MyDelegate(int x, int y, int z);
        static void Main(string[] args)
        {
            MyDelegate average = delegate (int x, int y, int z) { return (x + y + z) / 3; };

            Console.WriteLine(average(3, 7, 12));

            Console.ReadKey();
        }
    }
}
