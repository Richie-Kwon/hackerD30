using System;

namespace hackerank5
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (number < 2 || number > 20)
            {
                Console.WriteLine("Error : out of boundary.");
            }

            Multip(number);
        }

        private static void Multip(int number)
        {
            var answer = 1;
            for (var i = 1; i <= 10; i++)
            {
                answer = number * i;
                Console.WriteLine($"{number} x {i} = {answer}");
            }
        }
    }
}