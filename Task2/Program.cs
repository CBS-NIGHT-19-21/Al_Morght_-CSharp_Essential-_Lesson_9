using System;

namespace Task2
{
    internal class Program
    {
        public delegate int MyDelegate(int x, int y);
        static void Main(string[] args)
        {
            int choise, a, b;

            MyDelegate Add = (x, y) => { return x + y; };
            MyDelegate Sub = (x, y) => { return x - y; };
            MyDelegate Mul = (x, y) => { return x * y; };
            MyDelegate Div = (x, y) => { return (y != 0) ? x / y : 0; };

            Console.WriteLine("Выберите действие: \nСложение - 1\nВычитание - 2\nУножение - 3\nДеление - 4");
            choise = int.Parse(Console.ReadLine());

            Console.Write("\nВведите первое число: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("\nВведите второе число: ");
            b = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("\nСумма равна " + Add(a, b));
                    break;

                case 2:
                    Console.WriteLine("\nРазница равна " + Sub(a, b));
                    break;

                case 3:
                    Console.WriteLine("\nПроизведение равно " + Mul(a, b));
                    break;

                case 4:
                    Console.WriteLine("\nРезультат деления равен " + Div(a, b));
                    break;

                default:
                    Console.WriteLine("\nВыбран не существующий вариант.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
