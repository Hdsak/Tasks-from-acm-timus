using System;

namespace _1197._No_man_is_an_island
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] move = new string[n];
            for (int i = 0; i < n; i++)
            {
                move[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (move[i][0] >= 'c' && move[i][0] <= 'f' &&
                    move[i][1] >= '3' && move[i][1] <= '6')
                {
                    Console.WriteLine(8);
                }
                else if (((move[i][0] == 'b' || move[i][0] == 'g') && move[i][1] >= '3' && move[i][1] <= '6') ||
                    ((move[i][1] == '2' || move[i][1] == '7') && move[i][0] >= 'c' && move[i][0] <= 'f'))
                {
                    Console.WriteLine(6);
                }
                else if (move[i] == "a1" || move[i] == "a8" || move[i] == "h8" || move[i] == "h1")
                {
                    Console.WriteLine(2);
                }
                else if ((move[i][0] == 'a' && (move[i][1] == '2' || move[i][1] == '7')) ||
                    (move[i][0] == 'b' && (move[i][1] == '1' || move[i][1] == '8')) ||
                    (move[i][0] == 'g' && (move[i][1] == '1' || move[i][1] == '8')) ||
                    (move[i][0] == 'h' && (move[i][1] == '2' || move[i][1] == '7')))
                {
                    Console.WriteLine(3);
                }
                else
                    Console.WriteLine(4);
            }
        }
    }
}
