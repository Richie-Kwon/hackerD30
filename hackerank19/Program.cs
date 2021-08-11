using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerank19
{
    public int divisorSum(int n)
    {
    var totalSum = 0;
    for(int i =1; i == n ; i++)
    {
        if (n % i == 0) {
            totalSum+=i;
        }
        else{
        }
               
    }
    return totalSum;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}