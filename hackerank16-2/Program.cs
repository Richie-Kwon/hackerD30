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

namespace hackerank16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
        
            try{
                var data = int.Parse(S);   
                Console.WriteLine(data);  
                
            }    
            catch{
                Console.WriteLine("Bad String");
        }
    }
}