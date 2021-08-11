using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerank20
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Write your code here
            var temp = a[0];
            var sCount =0;
        
            for (int i=0; i< n; i++){
                if (i== n){
                    break;
                }
                for (int j = i+1; j < n ; j++) {
                    if (a[i] > a[j]){
                        sCount = sCount +1;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;                 
                    
                    }
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.",sCount);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n-1]);
        
        }
    }
}