using System;
namespace Demo 
{
    internal class Program 
    {
        #region Q1

        /*1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X,
    * and you should print how many numbers in array that is greater than  X
   */

        public static void Main()
        {
            string[] inputs = Console.ReadLine()!.Split();
            int N = int.Parse(inputs[0]);
            int Q = int.Parse(inputs[1]);


            int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            for (int i = 0; i < Q; i++)
            {
                int X = int.Parse(Console.ReadLine()!);
                int count = 0;

                for (int j = 0; j < N; j++)
                {
                    if (arr[j] > X)
                        count++;
                }
                Console.WriteLine(count);
            }
            Console.ReadKey();
        }

        #endregion


    }



}

