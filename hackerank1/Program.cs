using System;
using System.Collections.Generic;
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
                
                List<char> inputArray = new List<char>();
                inputArray.Add(input);
                // char[] inputArray = input.ToList();

                List<char> oddNumbers = new List<char>();
                List<char> evenNumbers = new List<char>();
                for (int j = 0; j < inputArray.Count; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenNumbers.Add(inputArray[j]);
                    }
                    else
                    {
                        oddNumbers.Add(inputArray[j]);
                    }
                }

                Console.WriteLine("{0}  {1}", oddNumbers, evenNumbers);
            }
        }
    }
}