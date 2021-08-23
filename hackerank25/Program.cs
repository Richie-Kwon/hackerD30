using System;

namespace hackerank25
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                bool prime = false;
                if (n == 2)
                {
                    prime = true;
                }
                else
                {

                    for (int j = 2; j < n / 2 + 1; j++)
                    {
                        if (n % j == 0)
                        {
                            prime = false;
                            break;

                        }

                        prime = true;
                    }

                }



                if (prime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}
