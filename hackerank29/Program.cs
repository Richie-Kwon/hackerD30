using System;
using System.IO;

namespace hackerank29
{
    class Program
    {
        s   public static int bitwiseAnd(int N, int K)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int count = Convert.ToInt32(firstMultipleInput[0]);

                int lim = Convert.ToInt32(firstMultipleInput[1]);

                int res = BitwiseAnd(count, lim);

                // textWriter.WriteLine(res);
                Console.WriteLine(res);
            }

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int count = Convert.ToInt32(firstMultipleInput[0]);

                int lim = Convert.ToInt32(firstMultipleInput[1]);

                int res = Result.bitwiseAnd(count, lim);

                textWriter.WriteLine(res);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }

    internal class Result
    {
    }
}
}