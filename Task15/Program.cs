// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine ("Введите номер дня недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

if (daynumber == 6 || daynumber == 7)
{
    Console.Write("Выходной день -> ");
}
else if (daynumber < 6 && daynumber != 0)
{
    Console.Write("Рабочий день -> ");
}

switch (daynumber)
{
case 1:
    Console.WriteLine ("Понедельник");
    break;

case 2:
    Console.WriteLine ("Вторник");
    break;

case 3:
    Console.WriteLine ("Среда");
    break;

case 4:
    Console.WriteLine ("Четверг");
    break;

case 5:
    Console.WriteLine ("Пятница");
    break;

case 6:
    Console.WriteLine ("Суббота");
    break;

case 7:
    Console.WriteLine ("Воскресенье");
    break;

default:
    Console.WriteLine("Такого дня недели нет");
    break;
}
