﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0; //to count  number of prime integers 
            int n = int.Parse(Console.ReadLine()); //number of input integers 
            int[] array = new int[n]; // we create a new array to save prime numbers
            string[] s = Console.ReadLine().Split(); //the numbers 
            for (int i = 0; i < n; i++)
            {
                int cnt1 = 0;//for counting number of possible dividers without remainder
                int k = int.Parse(s[i]);
                for (int j = 1; j < k; j++)
                {
                    if (k % j == 0)
                        cnt1++;
                }
                if (cnt1 == 1)
                    array[cnt++] = k;
            }
            Console.WriteLine(cnt); //the output number of the prime integers
            for (int i = 0; i < cnt; i++) //loop to output each of the prime integers
                Console.Write(array[i] + " ");
            Console.ReadKey();
        }
    }
}