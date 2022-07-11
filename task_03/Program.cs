/*
Задача 29: Напишите программу, которая задаёт случайный массив случайного размера 
(от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.

1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]

6, 1, 33 -> [36, 1, 1089]
*/
namespace Task_03
{
    class Program
    {
        public static void Main()
        {
            int [] array = new int[10];
            for ( int i = 0; i < array.Length; i++ )
            {   
                array[i] = new Random().Next(1, 41);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            PrintArray(array);   

        }
        public static void PrintArray (int[] array)
        {
            int square = 0;
            int length = array.Length;
            for(int i = 0; i < length; i++)
            {
            square = Convert.ToInt32(array[i].ToString());
            square = square * square;
            array[i] = square;
            Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

    }
}
