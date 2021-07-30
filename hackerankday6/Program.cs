using System;
using System.Text;

namespace hackerankday6
{
    class Program
    {
        static void Main(string[] args)
        {
            var runCount = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < runCount; k++)
            {
                var input = Console.ReadLine();
                var oddChars = new StringBuilder();
                var evenChars = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddChars.Append(input[i]);
                    }
                    else
                    {
                        evenChars.Append(input[i]);
                    }
                }
                Console.WriteLine($"{evenChars} {oddChars}");   
            }
        }
    }
}