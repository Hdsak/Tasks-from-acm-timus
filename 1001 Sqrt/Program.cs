using System;

//Исходные данные
//Входной поток содержит набор целых чисел Ai(0 ≤ Ai ≤ 1018), отделённых друг от друга произвольным количеством пробелов и
//переводов строк.Размер входного потока не превышает 256 КБ.
//Результат
//Для каждого числа Ai, начиная с последнего и заканчивая первым, в отдельной строке вывести
//его квадратный корень не менее чем с четырьмя знаками после десятичной точки.
namespace _1001_Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.In.ReadToEnd().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("{0:0.0000}", Math.Sqrt(double.Parse(n[i])));
            }
        }
    }
}
