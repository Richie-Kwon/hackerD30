﻿using System;
using System.Linq;


namespace hackerank14
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            elements = a;
        }

        // Add your code here
        public void computeDifference()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 1; j < elements.Length; j++)
                {
                    var absValue = Math.Abs(elements[i] - elements[j]);
                    if (maximumDifference < absValue) maximumDifference = absValue;
                }
            }
        }
    }
}