using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerank19
{
    public int divisorSum(int n)
    {
    var divisor = 0;
    var share = 0;
    var totalSum = 0;
        while (divisor + 1 <= n / (divisor + 1))
    {
        divisor += 1;
        if (n % divisor != 0) continue;

        share = n / divisor;
        totalSum += (divisor == share) ? divisor : divisor + share;
    }
    return totalSum;
        
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}