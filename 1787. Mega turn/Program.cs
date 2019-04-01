using System;

namespace _1787._Mega_turn
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string day_param = Console.ReadLine();
            string auto=Console.ReadLine();
            string[] day_params =day_param.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            string[] auto_params = auto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Convert.ToInt32(day_params[1]); i++)
            {
                sum += Convert.ToInt32(auto_params[i]);
                if (sum - Convert.ToInt32(day_params[0]) >= 0)
                { sum -= Convert.ToInt32(day_params[0]); }
                else
                { sum = 0; }
            }
            Console.WriteLine(sum);
        }
    }
}
