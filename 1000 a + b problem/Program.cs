using System;

namespace _1000_a___b_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string addition = Console.ReadLine();
            string[] numbers = addition.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in numbers)
            {
                sum += Convert.ToInt32(s);
            }
            Console.WriteLine(sum);
        }
    }
}
