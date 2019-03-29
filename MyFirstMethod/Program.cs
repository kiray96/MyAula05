using System;

namespace MyFirstMethod
{
    class Program
    {
        static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            CountToN(3);
            CountToN(9);
            CountTo10();
            CountTo10();

        }
    }
}
