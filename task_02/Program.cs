/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int Sum_digits_number()
{
    int sum = 0;
    Console.WriteLine("Введите число");
    int namber = Convert.ToInt32(Console.ReadLine());
    string str = Convert.ToString(namber);
    for (int i = 0; i < str.Length; i++)
    {
        sum += Convert.ToInt32(str[i].ToString());
    }
    return sum;
}
int sum = Sum_digits_number();
Console.WriteLine($"сумма цифр в числе = {sum}");