using System;

namespace _1785._Localization_problems
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 4)
            {
                Console.WriteLine("few");
            }
            else if (n >= 5 && n <= 9)
            {
                Console.WriteLine("several");
            }
            else if (n >= 10 && n <= 19)
            {
                Console.WriteLine("pack");
            }
            else if (n >= 20 && n <= 49)
            {
                Console.WriteLine("lots");
            }
            else if (n >= 50 && n <= 99)
            {
                Console.WriteLine("horde");
            }
            else if (n >= 100 && n <= 249)
            {
                Console.WriteLine("throng");
            }
            else if (n >= 250 && n <= 499)
            {
                Console.WriteLine("swarm");
            }
            else if (n >= 500 && n <= 999)
            {
                Console.WriteLine("zounds");
            }
            else if (n >= 1000 && n <= 2000)
            {
                Console.WriteLine("legion");
            }
        }
    }
}
