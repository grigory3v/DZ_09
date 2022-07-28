/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/
namespace Task_03
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
            funAkkerman(M: M, N: N);

            Console.WriteLine(funAkkerman(M, N));
        }
        static int funAkkerman(int N, int M)
        {
            if (N == 0)
                return M + 1;
            else
              if ((N != 0) && (M == 0))
                return funAkkerman(N - 1, 1);
            else
                return funAkkerman(N - 1, funAkkerman(N, M - 1));
        }

    }

}


