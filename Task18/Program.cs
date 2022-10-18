// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine ("Введите номер четверти");
string number = Console.ReadLine();

string quarter = Range (number);
Console.WriteLine($"Координаты: {quarter}");

string Range (string num)
{
if (num=="1") return ("X>0 и Y>0");
if (num=="2") return ("X<0 и Y>0");
if (num=="3") return ("X<0 и Y<0");
if (num=="4") return ("X>0 и Y<0");
return ("Такой четверти нет");
}



