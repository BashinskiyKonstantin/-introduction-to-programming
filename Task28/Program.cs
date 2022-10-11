// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitNumbers(int n)
{
    int average = 1;
    for (int i = 1; i <= n; i++)
    {
        average = average *i;
    
    }
    return average;
}
int digitNumbers = DigitNumbers(number);
System.Console.WriteLine($"Количество цифр равно -> {digitNumbers}");