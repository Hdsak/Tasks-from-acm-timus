using System;

namespace _1877._Bicycode
{
    class Program
    {
        static void Main(string[] args)
        {
            string s_1= Console.ReadLine();
            string s_2 = Console.ReadLine();
            if (s_1[s_1.Length - 1] % 2 == 0 || s_2[s_2.Length - 1] % 2 != 0 )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
