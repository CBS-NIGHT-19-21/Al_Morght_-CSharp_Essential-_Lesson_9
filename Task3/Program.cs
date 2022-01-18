using System;

namespace Task3
{
    internal class Program
    {
        public delegate int MyDelegate();

        public delegate int MyDelegate2(MyDelegate[] array);

        static int Method()
        {
            Random random = new Random();
            int result = random.Next(1, 100);

            return result;
        }

        static void Main(string[] args)
        {
            MyDelegate[] del = new MyDelegate[3];

            del[0] = new MyDelegate(Method);
            del[1] = new MyDelegate(Method);
            del[2] = new MyDelegate(Method);

            MyDelegate2 average = delegate (MyDelegate[] array) { return (array[0].Invoke() + array[1].Invoke() + array[2].Invoke())/array.Length; };

            Console.WriteLine("Среднее арифметическое " + average(del));

            Console.ReadKey();
        }
    }
}
