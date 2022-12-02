// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

if (n >= 0 && m >= 0) Console.WriteLine($"А({m},{n}) = {FunctionAkkerman(m, n)}");
else Console.WriteLine("Введены отрицательные числа!");
