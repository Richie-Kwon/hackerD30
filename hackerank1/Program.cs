using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hackerank1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countNoun = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countNoun; i++)
            {
                var input = Convert.ToString(Console.ReadLine());
                
                // List<string> inputArray = new List<string>();
                // inputArray.Add(input);
                char [] inputArray = input.ToArray();
                
                var oddNumbers = new List<char>();
                var evenNumbers = new List<char>();
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenNumbers.Add(Convert.ToChar(inputArray[j]));
                    }
                    else
                    {
                        oddNumbers.Add(Convert.ToChar(inputArray[j]));
                    }
                }

                Console.WriteLine("{0}  {1}", oddNumbers, evenNumbers);
            }
        }
    }
}