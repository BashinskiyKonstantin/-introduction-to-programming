// 0. Демонстрация решения
// Напишите программу, которая на вход принимает число
// и выдаёт его кврадрат (число умноженое само на себя).

// Например:
//     4 -> 16
//     -3 -> 9
//     -7 -> 16

Console.WriteLine ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine ());
int square = number * number;
Console.WriteLine ($"Квадрат числа {number} = {square}");
