﻿using System;
using System.Collections.Generic;
using System.IO;

namespace hackerank18
{
    class Program
    {
        static void Main(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }

    class Solution
    {
        //Write your code here

        private Stack<char> myStack = new Stack<char>();
        private Queue<char> myQueue = new Queue<char>();

        public void pushCharacter(char c)
        {
            myStack.Push(c);
        }

        public void enqueueCharacter(char c)
        {
            myQueue.Enqueue(c);
        }

        public char popCharacter()
        {
            return myStack.Pop();
        }

        public char dequeueCharacter()
        {
            return myQueue.Dequeue();
        }
    }
}