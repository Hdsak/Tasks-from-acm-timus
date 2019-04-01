using System;

namespace _2066._Simple_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0, max=0, middle=0;
            int first_number = Convert.ToInt32(Console.ReadLine());
            int second_number = Convert.ToInt32(Console.ReadLine());
            int third_number = Convert.ToInt32(Console.ReadLine());
            min = first_number;middle = second_number;max=third_number;
            Console.WriteLine(Math.Min(min-max*middle,min-middle-max));
        }
    }
}
