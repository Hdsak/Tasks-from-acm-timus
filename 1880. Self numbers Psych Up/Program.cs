using System;

namespace _1880._Self_numbers_Psych_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string self_number_count_1 = Console.ReadLine();
            string[] self_numbers_1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string self_number_count_2 = Console.ReadLine();
            string[] self_numbers_2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string self_number_count_3 = Console.ReadLine();
            string[] self_numbers_3 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in self_numbers_1)
            {
                foreach (string d in self_numbers_2)
                {
                    if (s == d)
                    {
                        foreach (string p in self_numbers_3)
                        {
                            if (d == p)
                            {
                                n++;
                            }
                        }
                    }
                }                
            }
            Console.WriteLine(n);
        }
    }
}
