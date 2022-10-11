// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int factorial = Factorial(number);
// Console.WriteLine($"Произведение чисел от 1 до {number} -> {factorial} ");

// int Factorial(int num)
// {
//     int fact = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         fact = fact * i;
//     }
//     return fact;
// }




long Factorial(long num)
{
    long fact = 1;
    int i;
    for (i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                fact = fact * i;
            }
        }
        catch (Exception)
        {
            System.Console.WriteLine("Переполнение типа!");
            break;
        }
    }

    System.Console.WriteLine($"Факториал числа {i - 1} = {fact}");
    return fact;
}
