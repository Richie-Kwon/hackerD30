using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace hackerank26
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                var returnedDate = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("en-GB"));
                var dueDate = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("en-GB"));




                var fine = 0;

                if (returnedDate > dueDate)
                {
                    if (returnedDate.Month == dueDate.Month)
                    {

                        fine = 15 * (returnedDate.Day - dueDate.Day);
                    }
                    else
                    {
                        if (returnedDate.Year == dueDate.Year)
                        {

                            fine = 500 * (returnedDate.Month - dueDate.Month);
                        }
                        else
                        {
                            fine = 10000;
                        }
                    }
                }

                Console.WriteLine(fine);

            }
        }
    }
}