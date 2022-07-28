/* 
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

namespace Task_01
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число M");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            number(M: M, N: N);

        }
        static void number(int M, int N)
        {

            for (; M <= N; M++)
            {
                Console.Write($"{M} ");
            }

        }

    }
}