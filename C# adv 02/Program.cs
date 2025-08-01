﻿using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Demo
{
    internal class Program
    {
        #region Q1

        /*1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X,
    * and you should print how many numbers in array that is greater than  X
   */

        //public static void Main()
        //{
        //    string[] inputs = Console.ReadLine()!.Split();
        //    int N = int.Parse(inputs[0]);
        //    int Q = int.Parse(inputs[1]);


        //    int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        //    for (int i = 0; i < Q; i++)
        //    {
        //        int X = int.Parse(Console.ReadLine()!);
        //        int count = 0;

        //        for (int j = 0; j < N; j++)
        //        {
        //            if (arr[j] > X)
        //                count++;
        //        }
        //        Console.WriteLine(count);
        //    }
        //    Console.ReadKey();
        //}

        #endregion

        #region Q2
        // 2. Given a number N and an array of N numbers.Determine if it's palindrome or not.
        //public static void Main() 
        //{
        //    int N = int.Parse(Console.ReadLine()!);
        //    int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        //    bool ispalindrome = true;

        //    for (int i = 0; i < N /2;i++)
        //    {
        //        if (arr[i] != arr[ N - 1 - i ])
        //        {
        //            ispalindrome = false;
        //            break;
        //        }    
        //    }
        //    if (ispalindrome)
        //    {
        //        Console.WriteLine("YES");
        //    }
        //    else { Console.WriteLine("NO"); }
        //    Console.ReadKey();
        // }

        #endregion

        #region Q3
        //public static void Main(string[] args) 
        //{
        //    Queue<int> queue = new Queue<int>();

        //    queue.Enqueue(1);
        //    queue.Enqueue(2);
        //    queue.Enqueue(3);
        //    queue.Enqueue(4);
        //    foreach (var item in queue)
        //    {
        //        Console.Write(item + " ");
        //    }

        //    ReverseQueue(queue);
        //    Console.WriteLine("\n after reverse");

        //    foreach (var item in queue)
        //    { Console.Write(item + " "); }

        //}



        //static void ReverseQueue(Queue<int> queue) 
        //{
        //    Stack <int> stack = new Stack<int>();

        //    while (queue.Count > 0) 
        //    {
        //    stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }

        //}



        #endregion

        #region Q4
        //public static void Main(string[] args) 
        //{
        //    string input = Console.ReadLine();
        //    bool CheckBalance = Isbalanced(input);
        //    Console.WriteLine(CheckBalance ? "Balance" : "UnBalance");     

        //}
        //static bool Isbalanced(string a) 
        //{
        //    Stack<char> stack = new Stack<char>();
        //    foreach (char c in a) 
        //    {
        //        if (c == '[' ||  c == '{' ||  c == '('  ) 
        //        {
        //            stack.Push(c);
        //        }
        //        else if (c==']' || c=='}' || c== ')' )
        //         {
        //            if (stack.Count== 0) return false;
        //            char top = stack.Pop();

        //         }


        //    }
        //    return stack.Count == 0;

        //}



        #endregion

        #region Q5
        //public static void Main(string[] args) 
        //{
        //    int[] arr = [1, 2, 3, 4, 5, 6, 6, 5, 4, 9, 10];
        //HashSet<int> numbers = new HashSet<int>(arr);
        //    foreach (int item in numbers) 
        //    {
        //        Console.WriteLine(item);
        //    }

        //}




        #endregion

        #region Q6

        //public static void Main(string[] args)
        //{
        // ArrayList arrayList = new ArrayList();
        //    for(int A= 0;A <= 10; A++ )
        //        arrayList.Add(A);
        //    Console.WriteLine("Before removing odd numbers: [" + string.Join(", ", arrayList.ToArray()) + "]");
        //    oddnumbers(arrayList);
        //    Console.WriteLine("After removing odd numbers: [" + string.Join(", ", arrayList.ToArray()) + "]");

        //}
        //static ArrayList oddnumbers(ArrayList arr)
        //{
        //    for (int i = arr.Count - 1; i >= 0; i--)
        //    {
        //        if (arr[i] is int Num  && Num % 2!=0)
        //        {
        //        arr.RemoveAt(i);
        //        }
        //    }
        //  return arr;
        //}

        #endregion

        #region Q7
        //public static void Main(string[] args) 
        //{
        //    Queue<object> Any = new Queue<object>();
        //    Any.Enqueue(1);
        //    Any.Enqueue("Apple");
        //    Any.Enqueue(5.28);

        //    foreach (var item in Any) { Console.WriteLine(item); }

        //}

        #endregion

        #region Q8
        public static void Main(string[] args)
        {
            #region Linked list


            //    LinkedList<int> list = new LinkedList<int>([1,2,3,4,5,6,7,8,9,10]);

            //    LinkedListNode<int> node = list.Find(5);

            //    if(node != null)
            //        Console.WriteLine("Target was found");
            //else
            //        Console.WriteLine("Target was not found");
            #endregion


            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("Enter the target to search for:");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            int count = 0;
            bool found = false;
            while (stack.Count > 0)
            {
                int current = stack.Pop();
                count++;
                if (current == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Target was not found");
            }
        }

        #endregion

    }

}
    


