/* 
Урок 4. Функции продолжение
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 
*/

void Degree(int number, int degree)
{
    int number_to_the_power = 1;
    for (int i = 0; i < degree; i++)
    {
        number_to_the_power = number_to_the_power * number;
    }
    Console.WriteLine($"число {number} в степени {degree} равно {number_to_the_power}");
}

Console.WriteLine("Введите число");
int namber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень");
int degree = Convert.ToInt32(Console.ReadLine());
Degree(number: namber, degree: degree);
