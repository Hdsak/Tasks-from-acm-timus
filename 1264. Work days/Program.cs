using System;

namespace _1264._Work_days
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = Console.ReadLine();
            string[] numbers = r.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int N = Convert.ToInt32(numbers[0]);
            int M = Convert.ToInt32(numbers[1]);
            Console.WriteLine(N*(M+1));
        }
    }
}
