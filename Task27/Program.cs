// Задача 27: Напишите программу, которая
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int remainder = 0;
    int sum = 0;
    int count = 0;
   
    while (num != 0)
    {   
        remainder = num % 10;
        sum = sum + remainder;
        num = num /10;
        count++;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр числа {number} равна -> {SumNumbers(number)}");