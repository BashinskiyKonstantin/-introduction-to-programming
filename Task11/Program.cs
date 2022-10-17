//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное => {number}");
int firstDigit = number / 100; // 4
int thirdDigit = number % 10; // 6

int number2 = firstDigit * 10 + thirdDigit;
Console.WriteLine ($"Результат={number2}");




