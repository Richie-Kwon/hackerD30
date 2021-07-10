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
                char[] inputarray = input.ToCharArray();

                List<char> oddNumbers = new List<char>();
                List<char> evenNumbers = new List<char>();
                for (int j = 0; j < inputarray.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenNumbers.Add(inputarray[j]);
                    }
                    else
                    {
                        oddNumbers.Add(inputarray[j]);
                    }
                }

                Console.WriteLine("{0}  {1}", oddNumbers, evenNumbers);
            }
        }
    }
}