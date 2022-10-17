// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number;
if (number % 100 == number)
{
    Console.WriteLine("Третьей цифры нет");

}
else
{
    while (remainder > 999) 
    {
        remainder = remainder / 10;  
    }
    remainder = remainder % 10; 
    Console.WriteLine($"Третья цифра числа {number} равна -> {remainder}");
}  
