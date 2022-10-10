// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write ($"Все четные числа от 0 до {number} -> ");

int counter = 0;
while (counter <= number)
{
    if (counter %2==0 && counter != 0)
    {
        Console.Write($"{counter}, ");
    }
    counter++;
}