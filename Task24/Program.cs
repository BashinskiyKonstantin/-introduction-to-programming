﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел до {number} равна -> {sumNumbers}");

int SumNumbers (int num)
{
    int sum = default;
    for (int i = 1; i <=num; i++)
    {
        sum += i;
    }
    return sum;
}