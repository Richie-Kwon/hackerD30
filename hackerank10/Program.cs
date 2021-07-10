using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hackerank10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            ByFunction(n);
        }

        static void ByFunction(int decimalNumber)
        {
            int remainder;
            string binary = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binary = remainder.ToString() + binary;
            }

            Console.WriteLine("{0}", binary);
            var splitBinary = binary.Split('0');
            var maxSplit = 0;
            foreach (var split in splitBinary)
            {
                if (split.Length > maxSplit)
                {
                    maxSplit = split.Length;
                }
            }

            Console.WriteLine(maxSplit);
        }
    }
}