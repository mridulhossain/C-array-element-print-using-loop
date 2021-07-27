using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray2 = new int[][]
            {
                    new int[] { 1, 3, 5, 7, 9 },
                    new int[] { 0, 2, 4, 6 },
                    new int[] { 11, 22 }
            };


            // useing for each.

            foreach (int[] array in jaggedArray2)
            {
                foreach (int innerElement in array)
                {
                    Console.Write(innerElement + " ");
                }
                Console.WriteLine();
            }

            // try to count inner element
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine(jaggedArray2[i].Length);
            }


            // useing forloop
            for (int i = 0; i<jaggedArray2.Length; i++)
            {
                for (int a = 0; a<jaggedArray2[i].Length; a++)
                {
                    Console.Write(jaggedArray2[i][a] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
