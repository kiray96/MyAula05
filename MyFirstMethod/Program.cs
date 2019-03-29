using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Print numbers 1 to the number of the variable :)
        /// </summary>
        /// <param name="n"> the variable </param>
        /// <returns></returns>
        static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }

        }

        /// <summary>
        /// Print numbers 1 to 10 :)
        /// </summary>
        /// <program> starts here </program>
        /// <returns>nothing</returns>
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// The main print all the resultes from previous methods :)
        /// </summary>
        /// <param name="string[]"> contains all the variables </param>
        /// <param name="args"> the arguments </param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            CountToN(3);
            CountToN(9);
            CountTo10();
            CountTo10();
            CountToN(1, 3);

        }
    }
}
