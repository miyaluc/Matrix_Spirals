using System;

namespace Matrix_Spirals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //m - rows, n - columns
        static void Spiralizer(int m, int n, int[,] structure)
        {
            int i, k = 0, l = 0;

            //k - this is the starting row index
            //m - ending row index
            //l - starting column index
            //n - ending column index
            //i - iterator

            //while starting row index < ending row index AND starting column index < ending column index
            while (k < m && l < n)
            {
                //printing the first (top) row 
                for (i = l; i < n; i++)
                {
                    Console.WriteLine(structure[k, i]);
                }
                k++;
            }
        }
    }
}
