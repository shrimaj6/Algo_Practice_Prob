﻿using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Insertion Program \n");

            int[] arr = { 12, 11, 13, 5 };
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;


                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + "  ");

            Console.Write("\n ");
        }
    }
}
