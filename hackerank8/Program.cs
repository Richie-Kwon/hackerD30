using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace hackerank8
{
    class Program
    {
        static void Main(string[] args)
        {
            var entryOfEntry = Convert.ToInt32(Console.ReadLine());
            IDictionary<string, string> phonebook = new Dictionary<string, string>();

            for (int i = 0; i < entryOfEntry; i++)
            {
                var keyValues = Console.ReadLine().Split(' ');
                phonebook.Add(keyValues[0], keyValues[1]);
            }

            var queryList = new List<string>();
            for (int j = 0; j < entryOfEntry; j++)
            {
                queryList.Add(Console.ReadLine());
            }

            foreach (string k in queryList)
            {
                if (phonebook.ContainsKey(k))
                {
                    Console.WriteLine("{0}={1}", k, phonebook[k]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}

