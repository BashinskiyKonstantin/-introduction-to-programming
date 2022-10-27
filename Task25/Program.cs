// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень числа {number}: ");
int naturalDegree = Convert.ToInt32(Console.ReadLine());

int Multiplication (int num,int degree)
{
    int multiplication= 1;
    for (int i = 1; i <= degree; i++)
    {
        multiplication = num * multiplication;
    }
    return multiplication;
}
if (naturalDegree> 0 && naturalDegree <= 10)
Console.WriteLine($"Натуральная степень числа {number} = {Multiplication (number, naturalDegree)}");
else Console.WriteLine($"Ошибка: Число {naturalDegree} не является натуральной степенью!");