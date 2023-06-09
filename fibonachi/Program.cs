using System;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // تعداد جملات در دنباله فیبوناچی

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
