using System;

namespace _2001._Math_and_berrys
{
    class Program
    {
        static void Main(string[] args)
        {
            int basket_1_weight = 0;
            int basket_2_weight = 0;
            string n_1 = Console.ReadLine();
            string n_2 = Console.ReadLine();
            string n_3 = Console.ReadLine();
            string[] w_1 = n_1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] w_2 = n_2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] w_3 = n_3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            basket_1_weight = Convert.ToInt32(w_3[0]);
            basket_2_weight = Convert.ToInt32(w_2[1]);
            Console.WriteLine($"{Convert.ToInt32(w_1[0]) - basket_1_weight} {Convert.ToInt32(w_1[1]) - basket_2_weight}");
        }
    }
}
