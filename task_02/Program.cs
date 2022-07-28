/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

namespace Task_02
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число M");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            number(M: M, N: N);

        }
        static void number(int M, int N)
        {
            int sum = 0;
            for (; M <= N; M++)
            {
                sum += M;
            }
            Console.Write($"{sum} ");
        }

    }
}