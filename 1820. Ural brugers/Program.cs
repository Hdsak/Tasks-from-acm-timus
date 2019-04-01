using System;

namespace _1820._Ural_brugers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] param = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if ((Convert.ToInt32(param[0]) * 2) == 0)
            {
                Console.WriteLine(0);
            }
            else if ((Convert.ToInt32(param[0]) * 2) < Convert.ToInt32(param[1]))
            {
                Console.WriteLine(2);
            }
            else if (((Convert.ToInt32(param[0]) * 2) % Convert.ToInt32(param[1]) != 0) || ((Convert.ToInt32(param[0]) * 2) == Convert.ToInt32(param[1])))
            {
                Console.WriteLine(((Convert.ToInt32(param[0]) * 2) / Convert.ToInt32(param[1])) + 1);
            }
            else if ((Convert.ToInt32(param[0]) * 2) % Convert.ToInt32(param[1]) == 0)
            {
                Console.WriteLine((Convert.ToInt32(param[0]) * 2) / Convert.ToInt32(param[1]));
            }
        }
    }
}
