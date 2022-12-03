// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите минимальное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num2 + SumNumbers(num1, num2 - 1);
}

if (num1 < num2) Console.WriteLine($"Cумма натуральных элементов в промежутке от {num1} до {num2} -> {SumNumbers(num1, num2)}");
else Console.WriteLine($"Cумма натуральных элементов в промежутке от {num1} до {num2} -> {SumNumbers(num2, num1)}");
