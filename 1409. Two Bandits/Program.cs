using System;

namespace _1409._Two_Bandits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])-1;
            Console.WriteLine($"{n-Convert.ToInt32(numbers[0])} {n-Convert.ToInt32(numbers[1])}");
        }
    }
}
