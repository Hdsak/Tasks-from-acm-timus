using System;

namespace _1293._Enia
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            string enia_params = Console.ReadLine();
            string[] param_s = enia_params.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in param_s)
            {
                result *= Convert.ToInt32(s);
            }
            Console.WriteLine(2*result);
        }
    }
}
